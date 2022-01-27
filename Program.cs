using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using Documoto.Services.Publishing;

namespace Documoto.Publishing.Client
{
    class Program
    {
        private static readonly PublishingServiceClient Client = new (PublishingServiceClient.EndpointConfiguration.PublishingService20HttpSoap12Endpoint,
            Environment.GetEnvironmentVariable("DOCUMOTO_API_ENDPOINT"));

        private static readonly string ApiKey       = Environment.GetEnvironmentVariable("DOCUMOTO_API_KEY");
        private static readonly string SupplierCode = Environment.GetEnvironmentVariable("DOCUMOTO_SUPPLIER_CODE");
        private static readonly string UserName     = Environment.GetEnvironmentVariable("DOCUMOTO_USER_NAME");

        private const int BatchLimit = 100;                             // Documoto maximum :(

        private const string RevisionLevelTag = "RevisionLevel";        // custom (tenant-specific) Tag


        static void Main()
        {
            FetchSuppliers();

            const string testPart = "SS101";
            FetchSinglePart(testPart);
            UpdateTagValue(testPart, RevisionLevelTag, "AA");

            FetchAllParts();

            CheckForDuplicateParts();

            var filePath = Path.Combine(Environment.CurrentDirectory, "Assets", "machine-tool.png");
            UploadFilesToBePublished(filePath);

            GetUploadedFilesList();
            GetUploadedFilesList("machine-tool");
        }

        private static void FetchSuppliers()
        {
            var request = new fetchSuppliersRequest(new FetchSuppliersRequestDto
            {
                tenantEncryptedKey = ApiKey
            });

            var response = Client.fetchSuppliers(request);

            var result = response.@return;
            if (result.responseCode != 0)
                throw new Exception($"FetchSuppliers failed: status = {result.responseCode}, message = {result.responseMessage}");

            var codes = result.supplierCodes.ToList();
            codes.ForEach(code => Console.WriteLine($"Supplier: {code}"));

            if (!codes.Contains(SupplierCode))
                Console.WriteLine($"Supplier Code {SupplierCode} is not present in Documoto catalog");
        }

        private static PartDto FetchSinglePart(string partNumber)
        {
            var request = new fetchPartsRequest(new FetchPartRequestDto[] 
            {
                new() {
                    limit              = BatchLimit,
                    partNumber         = partNumber,
                    supplierKey        = SupplierCode,
                    tenantEncryptedKey = ApiKey,
                }
            });

            var response = Client.fetchParts(request);

            var result = response.@return[0];
            if (result.responseCode != 0)
                throw new Exception($"FetchPart failed: status = {result.responseCode}, message = {result.responseMessage}");

            if (result.partsFound == null || result.partsFound.Length != 1)
                throw new Exception("FetchPart failed: no Part returned in result");

            var part = result.partsFound[0];

            Console.WriteLine($"Fetched Part: number = {part.partNumber}, name = {part.partName}");

            return part;
        }

        private static void FetchAllParts()
        {
            var request = new fetchPartsRequest(new FetchPartRequestDto[]
            {
                new() {
                    supplierKey        = SupplierCode,
                    tenantEncryptedKey = ApiKey,

                    start              = 0,
                    startSpecified     = true,

                    limit              = BatchLimit,
                    limitSpecified     = true,
                }
            });

            var response = Client.fetchParts(request);
            var result = response.@return[0];
            if (result.responseCode != 0)
                throw new Exception($"FetchAllParts failed: status = {result.responseCode}, message = {result.responseMessage}");

            var totalParts = result.total;
            Console.WriteLine($"Total Parts in Documoto catalog for Supplier {SupplierCode} = {totalParts}");

            var partsCollected = 0;

            while (true)
            {
                foreach (var part in result.partsFound)
                {
                    Console.WriteLine($"{part.partNumber, -30}{part.partName, -60}{GetTagValue(part, RevisionLevelTag)}");
                    partsCollected++;
                }

                if (partsCollected == totalParts)
                    break;

                request.requests[0].start = partsCollected;

                response = Client.fetchParts(request);
                result = response.@return[0];
                if (result.responseCode != 0)
                    throw new Exception($"FetchAllParts failed: status = {result.responseCode}, message = {result.responseMessage}");
            }
        }

        private static void CheckForDuplicateParts()
        {
            var parts = new Dictionary<string, List<string>>();

            var request = new fetchPartsRequest(new FetchPartRequestDto[]
            {
                new() {
                    supplierKey        = SupplierCode,
                    tenantEncryptedKey = ApiKey,

                    start              = 0,
                    startSpecified     = true,

                    limit              = BatchLimit,
                    limitSpecified     = true,
                }
            });

            var response = Client.fetchParts(request);
            var result = response.@return[0];
            if (result.responseCode != 0)
                throw new Exception($"FetchAllParts failed: status = {result.responseCode}, message = {result.responseMessage}");

            var totalParts = result.total;
            Console.WriteLine($"Total Parts in Documoto catalog for Supplier {SupplierCode} = {totalParts}");

            var partsCollected = 0;

            while (true)
            {
                foreach (var part in result.partsFound)
                {
                    var normalizedPartNumber = part.partNumber.ToUpper();   // Documoto identifiers are case-sensitive
                    if (!parts.ContainsKey(normalizedPartNumber))
                        parts.Add(normalizedPartNumber, new List<string>());
                    parts[normalizedPartNumber].Add(part.partNumber);

                    Console.WriteLine($"{part.partNumber, -30}{part.partName, -60}{GetTagValue(part, RevisionLevelTag)}");
                    partsCollected++;
                }

                if (partsCollected == totalParts)
                    break;

                request.requests[0].start = partsCollected;

                response = Client.fetchParts(request);
                result = response.@return[0];
                if (result.responseCode != 0)
                    throw new Exception($"FetchAllParts failed: status = {result.responseCode}, message = {result.responseMessage}");
            }

            parts.Where(p => p.Value.Count > 1)
                .ToList()
                .ForEach(d => 
                    Console.WriteLine($"{d.Key}: {string.Join(",", d.Value)}"));
        }

        private static string GetTagValue(PartDto part, string tagName)
        {
            if (part.tags == null || part.tags.Length == 0)
                return null;

            var tag = part.tags.FirstOrDefault(t => t.tagName.Equals(tagName));
            return tag?.tagValue;
        }

        private static void UpdateTagValue(string partNumber, string tagName, string tagValue)
        {
            var part = FetchSinglePart(partNumber);
            if (part == null)
                throw new Exception($"Part {partNumber} not found in Documoto catalog");

            var request = new updatePartsRequest(new UpdatePartRequestDto[]
            {
                new() {
                    tenantEncryptedKey          = ApiKey,

                    supplierKey                 = SupplierCode,
                    partNumber                  = partNumber,

                    newPartData                 = new PartDto(),

                    replaceAllPartTagsSpecified = true,
                    replaceAllPartTags          = true,

                    userName                    = UserName,              // valid user (with appropriate rights) is mandatory, for any Documoto update
                }
            });

            var tagList = (part.tags == null) ? new List<TagDto>() : part.tags.ToList();

            tagList.RemoveAll(t => t.tagName.Equals(tagValue));
            tagList.Add(new TagDto { tagName = tagName, tagValue = tagValue });

            request.requests[0].newPartData.tags = tagList.ToArray();

            var response = Client.updateParts(request);

            var result = response.@return[0];
            if (result.responseCode != 0)
                throw new Exception($"UpdatePart failed: status = {result.responseCode}, message = {result.responseMessage}");
        }

        private static void UploadFilesToBePublished(string filePath)
        {
            var request = new uploadFileToBePublishedRequest(new UploadFileToBePublishedRequestDto[]
            {
                new()
                {
                    tenantEncryptedKey  = ApiKey,
                    userName            = UserName,

                    fileName            = Path.GetFileName(filePath),
                    dataHandler         = File.ReadAllBytes(filePath).BinaryToBase64Binary(),

                    submitForPublishing = false,
                }
            });

            var response = Client.uploadFileToBePublished(request);

            var result = response.@return[0];
            if (result.responseCode != 0)
                throw new Exception($"UploadFilesToBePublished failed: status = {result.responseCode}, message = {result.responseMessage}");
        }

        private static void GetUploadedFilesList(string filenameFilter = null)
        {
            var request = new getUploadedFilesListRequest(new GetUploadedFilesListRequestDto
            {
                tenantEncryptedKey = ApiKey,
                filenameFilter     = filenameFilter,
            });

            var response = Client.getUploadedFilesList(request);

            var result = response.@return;
            if (result.responseCode != 0)
                throw new Exception($"GetUploadedFilesList failed: status = {result.responseCode}, message = {result.responseMessage}");

        }

    }
}
