using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Documoto.Services.Publishing
{
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [ServiceContractAttribute(Namespace="http://impl.webservices.digabit.com", ConfigurationName="PublishingService20PortType")]
    public interface PublishingService
    {
        
        [OperationContractAttribute(Action="urn:fetchTagValuesForMediaByTagName", ReplyAction="urn:fetchTagValuesForMediaByTagNameResponse")]
        [XmlSerializerFormatAttribute(SupportFaults=true)]
        [ServiceKnownTypeAttribute(typeof(AbstractResponseDto))]
        [ServiceKnownTypeAttribute(typeof(AbstractDto))]
        fetchTagValuesForMediaByTagNameResponse fetchTagValuesForMediaByTagName(fetchTagValuesForMediaByTagNameRequest request);
        
        [OperationContractAttribute(Action="urn:fetchTagValuesForMediaByTagName", ReplyAction="urn:fetchTagValuesForMediaByTagNameResponse")]
        Task<fetchTagValuesForMediaByTagNameResponse> fetchTagValuesForMediaByTagNameAsync(fetchTagValuesForMediaByTagNameRequest request);
        
        [OperationContractAttribute(Action="urn:fetchMediaIdentifiers", ReplyAction="urn:fetchMediaIdentifiersResponse")]
        [XmlSerializerFormatAttribute(SupportFaults=true)]
        [ServiceKnownTypeAttribute(typeof(AbstractResponseDto))]
        [ServiceKnownTypeAttribute(typeof(AbstractDto))]
        fetchMediaIdentifiersResponse fetchMediaIdentifiers(fetchMediaIdentifiersRequest request);
        
        [OperationContractAttribute(Action="urn:fetchMediaIdentifiers", ReplyAction="urn:fetchMediaIdentifiersResponse")]
        Task<fetchMediaIdentifiersResponse> fetchMediaIdentifiersAsync(fetchMediaIdentifiersRequest request);
        
        [OperationContractAttribute(Action="urn:supersedePart", ReplyAction="urn:supersedePartResponse")]
        [XmlSerializerFormatAttribute(SupportFaults=true)]
        [ServiceKnownTypeAttribute(typeof(AbstractResponseDto))]
        [ServiceKnownTypeAttribute(typeof(AbstractDto))]
        supersedePartResponse supersedePart(supersedePartRequest request);
        
        [OperationContractAttribute(Action="urn:supersedePart", ReplyAction="urn:supersedePartResponse")]
        Task<supersedePartResponse> supersedePartAsync(supersedePartRequest request);
        
        [OperationContractAttribute(Action="urn:updateMediaForBoolean", ReplyAction="urn:updateMediaForBooleanResponse")]
        [XmlSerializerFormatAttribute(SupportFaults=true)]
        [ServiceKnownTypeAttribute(typeof(AbstractResponseDto))]
        [ServiceKnownTypeAttribute(typeof(AbstractDto))]
        updateMediaForBooleanResponse updateMediaForBoolean(updateMediaForBooleanRequest request);
        
        [OperationContractAttribute(Action="urn:updateMediaForBoolean", ReplyAction="urn:updateMediaForBooleanResponse")]
        Task<updateMediaForBooleanResponse> updateMediaForBooleanAsync(updateMediaForBooleanRequest request);
        
        [OperationContractAttribute(Action="urn:setAccessControls", ReplyAction="urn:setAccessControlsResponse")]
        [XmlSerializerFormatAttribute(SupportFaults=true)]
        [ServiceKnownTypeAttribute(typeof(AbstractResponseDto))]
        [ServiceKnownTypeAttribute(typeof(AbstractDto))]
        setAccessControlsResponse setAccessControls(setAccessControlsRequest request);
        
        [OperationContractAttribute(Action="urn:setAccessControls", ReplyAction="urn:setAccessControlsResponse")]
        Task<setAccessControlsResponse> setAccessControlsAsync(setAccessControlsRequest request);
        
        [OperationContractAttribute(Action="urn:fetchOrganizationAccessForMedia", ReplyAction="urn:fetchOrganizationAccessForMediaResponse")]
        [XmlSerializerFormatAttribute(SupportFaults=true)]
        [ServiceKnownTypeAttribute(typeof(AbstractResponseDto))]
        [ServiceKnownTypeAttribute(typeof(AbstractDto))]
        fetchOrganizationAccessForMediaResponse fetchOrganizationAccessForMedia(fetchOrganizationAccessForMediaRequest request);
        
        [OperationContractAttribute(Action="urn:fetchOrganizationAccessForMedia", ReplyAction="urn:fetchOrganizationAccessForMediaResponse")]
        Task<fetchOrganizationAccessForMediaResponse> fetchOrganizationAccessForMediaAsync(fetchOrganizationAccessForMediaRequest request);
        
        [OperationContractAttribute(Action="urn:exportMedia", ReplyAction="urn:exportMediaResponse")]
        [XmlSerializerFormatAttribute(SupportFaults=true)]
        [ServiceKnownTypeAttribute(typeof(AbstractResponseDto))]
        [ServiceKnownTypeAttribute(typeof(AbstractDto))]
        exportMediaResponse exportMedia(exportMediaRequest request);
        
        [OperationContractAttribute(Action="urn:exportMedia", ReplyAction="urn:exportMediaResponse")]
        Task<exportMediaResponse> exportMediaAsync(exportMediaRequest request);
        
        [OperationContractAttribute(Action="urn:fetchTagsForMedia", ReplyAction="urn:fetchTagsForMediaResponse")]
        [XmlSerializerFormatAttribute(SupportFaults=true)]
        [ServiceKnownTypeAttribute(typeof(AbstractResponseDto))]
        [ServiceKnownTypeAttribute(typeof(AbstractDto))]
        fetchTagsForMediaResponse fetchTagsForMedia(fetchTagsForMediaRequest request);
        
        [OperationContractAttribute(Action="urn:fetchTagsForMedia", ReplyAction="urn:fetchTagsForMediaResponse")]
        Task<fetchTagsForMediaResponse> fetchTagsForMediaAsync(fetchTagsForMediaRequest request);
        
        [OperationContractAttribute(Action="urn:validateBookContent", ReplyAction="urn:validateBookContentResponse")]
        [XmlSerializerFormatAttribute(SupportFaults=true)]
        [ServiceKnownTypeAttribute(typeof(AbstractResponseDto))]
        [ServiceKnownTypeAttribute(typeof(AbstractDto))]
        validateBookContentResponse validateBookContent(validateBookContentRequest request);
        
        [OperationContractAttribute(Action="urn:validateBookContent", ReplyAction="urn:validateBookContentResponse")]
        Task<validateBookContentResponse> validateBookContentAsync(validateBookContentRequest request);
        
        [OperationContractAttribute(Action="urn:updateMedia", ReplyAction="urn:updateMediaResponse")]
        [XmlSerializerFormatAttribute(SupportFaults=true)]
        [ServiceKnownTypeAttribute(typeof(AbstractResponseDto))]
        [ServiceKnownTypeAttribute(typeof(AbstractDto))]
        updateMediaResponse updateMedia(updateMediaRequest request);
        
        [OperationContractAttribute(Action="urn:updateMedia", ReplyAction="urn:updateMediaResponse")]
        Task<updateMediaResponse> updateMediaAsync(updateMediaRequest request);
        
        [OperationContractAttribute(Action="urn:fetchMediaShelvesForMedia", ReplyAction="urn:fetchMediaShelvesForMediaResponse")]
        [XmlSerializerFormatAttribute(SupportFaults=true)]
        [ServiceKnownTypeAttribute(typeof(AbstractResponseDto))]
        [ServiceKnownTypeAttribute(typeof(AbstractDto))]
        fetchMediaShelvesForMediaResponse fetchMediaShelvesForMedia(fetchMediaShelvesForMediaRequest request);
        
        [OperationContractAttribute(Action="urn:fetchMediaShelvesForMedia", ReplyAction="urn:fetchMediaShelvesForMediaResponse")]
        Task<fetchMediaShelvesForMediaResponse> fetchMediaShelvesForMediaAsync(fetchMediaShelvesForMediaRequest request);
        
        [OperationContractAttribute(Action="urn:validatePageFiles", ReplyAction="urn:validatePageFilesResponse")]
        [XmlSerializerFormatAttribute(SupportFaults=true)]
        [ServiceKnownTypeAttribute(typeof(AbstractResponseDto))]
        [ServiceKnownTypeAttribute(typeof(AbstractDto))]
        validatePageFilesResponse validatePageFiles(validatePageFilesRequest request);
        
        [OperationContractAttribute(Action="urn:validatePageFiles", ReplyAction="urn:validatePageFilesResponse")]
        Task<validatePageFilesResponse> validatePageFilesAsync(validatePageFilesRequest request);
        
        [OperationContractAttribute(Action="urn:updateParts", ReplyAction="urn:updatePartsResponse")]
        [XmlSerializerFormatAttribute(SupportFaults=true)]
        [ServiceKnownTypeAttribute(typeof(AbstractResponseDto))]
        [ServiceKnownTypeAttribute(typeof(AbstractDto))]
        updatePartsResponse updateParts(updatePartsRequest request);
        
        [OperationContractAttribute(Action="urn:updateParts", ReplyAction="urn:updatePartsResponse")]
        Task<updatePartsResponse> updatePartsAsync(updatePartsRequest request);
        
        [OperationContractAttribute(Action="urn:getUploadedFilesList", ReplyAction="urn:getUploadedFilesListResponse")]
        [XmlSerializerFormatAttribute(SupportFaults=true)]
        [ServiceKnownTypeAttribute(typeof(AbstractResponseDto))]
        [ServiceKnownTypeAttribute(typeof(AbstractDto))]
        getUploadedFilesListResponse getUploadedFilesList(getUploadedFilesListRequest request);
        
        [OperationContractAttribute(Action="urn:getUploadedFilesList", ReplyAction="urn:getUploadedFilesListResponse")]
        Task<getUploadedFilesListResponse> getUploadedFilesListAsync(getUploadedFilesListRequest request);
        
        [OperationContractAttribute(Action="urn:getJobStatus", ReplyAction="urn:getJobStatusResponse")]
        [XmlSerializerFormatAttribute(SupportFaults=true)]
        [ServiceKnownTypeAttribute(typeof(AbstractResponseDto))]
        [ServiceKnownTypeAttribute(typeof(AbstractDto))]
        getJobStatusResponse getJobStatus(getJobStatusRequest request);
        
        [OperationContractAttribute(Action="urn:getJobStatus", ReplyAction="urn:getJobStatusResponse")]
        Task<getJobStatusResponse> getJobStatusAsync(getJobStatusRequest request);
        
        [OperationContractAttribute(Action="urn:partLookup", ReplyAction="urn:partLookupResponse")]
        [XmlSerializerFormatAttribute(SupportFaults=true)]
        [ServiceKnownTypeAttribute(typeof(AbstractResponseDto))]
        [ServiceKnownTypeAttribute(typeof(AbstractDto))]
        partLookupResponse partLookup(partLookupRequest request);
        
        [OperationContractAttribute(Action="urn:partLookup", ReplyAction="urn:partLookupResponse")]
        Task<partLookupResponse> partLookupAsync(partLookupRequest request);
        
        [OperationContractAttribute(Action="urn:fetchSuppliers", ReplyAction="urn:fetchSuppliersResponse")]
        [XmlSerializerFormatAttribute(SupportFaults=true)]
        [ServiceKnownTypeAttribute(typeof(AbstractResponseDto))]
        [ServiceKnownTypeAttribute(typeof(AbstractDto))]
        fetchSuppliersResponse fetchSuppliers(fetchSuppliersRequest request);
        
        [OperationContractAttribute(Action="urn:fetchSuppliers", ReplyAction="urn:fetchSuppliersResponse")]
        Task<fetchSuppliersResponse> fetchSuppliersAsync(fetchSuppliersRequest request);
        
        [OperationContractAttribute(Action="urn:fetchParts", ReplyAction="urn:fetchPartsResponse")]
        [XmlSerializerFormatAttribute(SupportFaults=true)]
        [ServiceKnownTypeAttribute(typeof(AbstractResponseDto))]
        [ServiceKnownTypeAttribute(typeof(AbstractDto))]
        fetchPartsResponse fetchParts(fetchPartsRequest request);
        
        [OperationContractAttribute(Action="urn:fetchParts", ReplyAction="urn:fetchPartsResponse")]
        Task<fetchPartsResponse> fetchPartsAsync(fetchPartsRequest request);
        
        [OperationContractAttribute(Action="urn:publishFiles", ReplyAction="urn:publishFilesResponse")]
        [XmlSerializerFormatAttribute(SupportFaults=true)]
        [ServiceKnownTypeAttribute(typeof(AbstractResponseDto))]
        [ServiceKnownTypeAttribute(typeof(AbstractDto))]
        publishFilesResponse publishFiles(publishFilesRequest request);
        
        [OperationContractAttribute(Action="urn:publishFiles", ReplyAction="urn:publishFilesResponse")]
        Task<publishFilesResponse> publishFilesAsync(publishFilesRequest request);
        
        [OperationContractAttribute(Action="urn:deleteTagValuesForTagNameOnMedia", ReplyAction="urn:deleteTagValuesForTagNameOnMediaResponse")]
        [XmlSerializerFormatAttribute(SupportFaults=true)]
        [ServiceKnownTypeAttribute(typeof(AbstractResponseDto))]
        [ServiceKnownTypeAttribute(typeof(AbstractDto))]
        deleteTagValuesForTagNameOnMediaResponse deleteTagValuesForTagNameOnMedia(deleteTagValuesForTagNameOnMediaRequest request);
        
        [OperationContractAttribute(Action="urn:deleteTagValuesForTagNameOnMedia", ReplyAction="urn:deleteTagValuesForTagNameOnMediaResponse")]
        Task<deleteTagValuesForTagNameOnMediaResponse> deleteTagValuesForTagNameOnMediaAsync(deleteTagValuesForTagNameOnMediaRequest request);
        
        [OperationContractAttribute(Action="urn:fetchMedia", ReplyAction="urn:fetchMediaResponse")]
        [XmlSerializerFormatAttribute(SupportFaults=true)]
        [ServiceKnownTypeAttribute(typeof(AbstractResponseDto))]
        [ServiceKnownTypeAttribute(typeof(AbstractDto))]
        fetchMediaResponse fetchMedia(fetchMediaRequest request);
        
        [OperationContractAttribute(Action="urn:fetchMedia", ReplyAction="urn:fetchMediaResponse")]
        Task<fetchMediaResponse> fetchMediaAsync(fetchMediaRequest request);
        
        [OperationContractAttribute(Action="urn:updatePagePartTags", ReplyAction="urn:updatePagePartTagsResponse")]
        [XmlSerializerFormatAttribute(SupportFaults=true)]
        [ServiceKnownTypeAttribute(typeof(AbstractResponseDto))]
        [ServiceKnownTypeAttribute(typeof(AbstractDto))]
        updatePagePartTagsResponse updatePagePartTags(updatePagePartTagsRequest request);
        
        [OperationContractAttribute(Action="urn:updatePagePartTags", ReplyAction="urn:updatePagePartTagsResponse")]
        Task<updatePagePartTagsResponse> updatePagePartTagsAsync(updatePagePartTagsRequest request);
        
        [OperationContractAttribute(Action="urn:uploadFileToBePublished", ReplyAction="urn:uploadFileToBePublishedResponse")]
        [XmlSerializerFormatAttribute(SupportFaults=true)]
        [ServiceKnownTypeAttribute(typeof(AbstractResponseDto))]
        [ServiceKnownTypeAttribute(typeof(AbstractDto))]
        uploadFileToBePublishedResponse uploadFileToBePublished(uploadFileToBePublishedRequest request);
        
        [OperationContractAttribute(Action="urn:uploadFileToBePublished", ReplyAction="urn:uploadFileToBePublishedResponse")]
        Task<uploadFileToBePublishedResponse> uploadFileToBePublishedAsync(uploadFileToBePublishedRequest request);
        
        [OperationContractAttribute(Action="urn:updateLocationData", ReplyAction="urn:updateLocationDataResponse")]
        [XmlSerializerFormatAttribute(SupportFaults=true)]
        [ServiceKnownTypeAttribute(typeof(AbstractResponseDto))]
        [ServiceKnownTypeAttribute(typeof(AbstractDto))]
        updateLocationDataResponse updateLocationData(updateLocationDataRequest request);
        
        [OperationContractAttribute(Action="urn:updateLocationData", ReplyAction="urn:updateLocationDataResponse")]
        Task<updateLocationDataResponse> updateLocationDataAsync(updateLocationDataRequest request);
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://request.dto.webservices.digabit.com/xsd")]
    public partial class FetchTagValuesForMediaByTagNameRequestDto : AbstractRequestDto
    {
        
        private Nullable<int> limitField;
        
        private bool limitFieldSpecified;
        
        private string mediaIdentiferField;
        
        private Nullable<int> startField;
        
        private bool startFieldSpecified;
        
        private string tagNameField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public Nullable<int> limit
        {
            get
            {
                return this.limitField;
            }
            set
            {
                this.limitField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool limitSpecified
        {
            get
            {
                return this.limitFieldSpecified;
            }
            set
            {
                this.limitFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public string mediaIdentifer
        {
            get
            {
                return this.mediaIdentiferField;
            }
            set
            {
                this.mediaIdentiferField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=2)]
        public Nullable<int> start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool startSpecified
        {
            get
            {
                return this.startFieldSpecified;
            }
            set
            {
                this.startFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=3)]
        public string tagName
        {
            get
            {
                return this.tagNameField;
            }
            set
            {
                this.tagNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [XmlIncludeAttribute(typeof(FetchSuppliersRequestDto))]
    [XmlIncludeAttribute(typeof(UpdateLocationDataRequestDto))]
    [XmlIncludeAttribute(typeof(ValidateBookContentRequestDto))]
    [XmlIncludeAttribute(typeof(SetAccessControlsRequestDto))]
    [XmlIncludeAttribute(typeof(UpdatePartRequestDto))]
    [XmlIncludeAttribute(typeof(FetchPartRequestDto))]
    [XmlIncludeAttribute(typeof(PartLookupRequestDto))]
    [XmlIncludeAttribute(typeof(GetJobStatusRequestDto))]
    [XmlIncludeAttribute(typeof(PublishFilesRequestDto))]
    [XmlIncludeAttribute(typeof(GetUploadedFilesListRequestDto))]
    [XmlIncludeAttribute(typeof(AbstractPaginatedRequestDto))]
    [XmlIncludeAttribute(typeof(FetchMediaIdentifiersRequestDto))]
    [XmlIncludeAttribute(typeof(FetchTagsForMediaRequestDto))]
    [XmlIncludeAttribute(typeof(FetchTagValuesForMediaByTagNameRequestDto))]
    [XmlIncludeAttribute(typeof(DeleteTagValuesForTagNameOnMediaRequestDto))]
    [XmlIncludeAttribute(typeof(FetchMediaRequestDto))]
    [XmlIncludeAttribute(typeof(ExportMediaRequestDto))]
    [XmlIncludeAttribute(typeof(UpdatePagePartTagsRequestDto))]
    [XmlIncludeAttribute(typeof(UploadFileToBePublishedRequestDto))]
    [XmlIncludeAttribute(typeof(SupersedePartRequestDto))]
    [XmlIncludeAttribute(typeof(UpdateMediaRequestDto))]
    [XmlIncludeAttribute(typeof(ValidatePageFileRequestDto))]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://request.dto.webservices.digabit.com/xsd")]
    public partial class AbstractRequestDto
    {
        
        private string tenantEncryptedKeyField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public string tenantEncryptedKey
        {
            get
            {
                return this.tenantEncryptedKeyField;
            }
            set
            {
                this.tenantEncryptedKeyField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://entity.dto.webservices.digabit.com/xsd")]
    public partial class PagePartsListHotpointValidationBeanDto
    {
        
        private string[] hotpointsInSvgNotInDbField;
        
        private string[] itemsInDbNotInSvgField;
        
        private Nullable<int> numberOfHotpointsInDbField;
        
        private bool numberOfHotpointsInDbFieldSpecified;
        
        private Nullable<int> numberOfHotpointsInSvgField;
        
        private bool numberOfHotpointsInSvgFieldSpecified;
        
        /// <remarks/>
        [XmlElementAttribute("hotpointsInSvgNotInDb", IsNullable=true, Order=0)]
        public string[] hotpointsInSvgNotInDb
        {
            get
            {
                return this.hotpointsInSvgNotInDbField;
            }
            set
            {
                this.hotpointsInSvgNotInDbField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute("itemsInDbNotInSvg", IsNullable=true, Order=1)]
        public string[] itemsInDbNotInSvg
        {
            get
            {
                return this.itemsInDbNotInSvgField;
            }
            set
            {
                this.itemsInDbNotInSvgField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=2)]
        public Nullable<int> numberOfHotpointsInDb
        {
            get
            {
                return this.numberOfHotpointsInDbField;
            }
            set
            {
                this.numberOfHotpointsInDbField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool numberOfHotpointsInDbSpecified
        {
            get
            {
                return this.numberOfHotpointsInDbFieldSpecified;
            }
            set
            {
                this.numberOfHotpointsInDbFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=3)]
        public Nullable<int> numberOfHotpointsInSvg
        {
            get
            {
                return this.numberOfHotpointsInSvgField;
            }
            set
            {
                this.numberOfHotpointsInSvgField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool numberOfHotpointsInSvgSpecified
        {
            get
            {
                return this.numberOfHotpointsInSvgFieldSpecified;
            }
            set
            {
                this.numberOfHotpointsInSvgFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://entity.dto.webservices.digabit.com/xsd")]
    public partial class PageValidationBeanDto
    {
        
        private PageFileValidationBeanDto pageFileValidationBeanDtoField;
        
        private PagePartsListHotpointValidationBeanDto pagePartsListHotpointValidationBeanDtoField;
        
        private TranslationDto[] translationsField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public PageFileValidationBeanDto pageFileValidationBeanDto
        {
            get
            {
                return this.pageFileValidationBeanDtoField;
            }
            set
            {
                this.pageFileValidationBeanDtoField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public PagePartsListHotpointValidationBeanDto pagePartsListHotpointValidationBeanDto
        {
            get
            {
                return this.pagePartsListHotpointValidationBeanDtoField;
            }
            set
            {
                this.pagePartsListHotpointValidationBeanDtoField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute("translations", IsNullable=true, Order=2)]
        public TranslationDto[] translations
        {
            get
            {
                return this.translationsField;
            }
            set
            {
                this.translationsField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://entity.dto.webservices.digabit.com/xsd")]
    public partial class PageFileValidationBeanDto
    {
        
        private Nullable<bool> fileFoundOnContentServerField;
        
        private bool fileFoundOnContentServerFieldSpecified;
        
        private string fileNameField;
        
        private Nullable<bool> isImageFileField;
        
        private bool isImageFileFieldSpecified;
        
        private Nullable<bool> isSvgFileField;
        
        private bool isSvgFileFieldSpecified;
        
        private Nullable<bool> svgImageReferenceFileFoundOnContentServerField;
        
        private bool svgImageReferenceFileFoundOnContentServerFieldSpecified;
        
        private Nullable<bool> svgImageReferenceFileProcessedByTileConverterField;
        
        private bool svgImageReferenceFileProcessedByTileConverterFieldSpecified;
        
        private string svgPrimaryImageFileNameField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public Nullable<bool> fileFoundOnContentServer
        {
            get
            {
                return this.fileFoundOnContentServerField;
            }
            set
            {
                this.fileFoundOnContentServerField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool fileFoundOnContentServerSpecified
        {
            get
            {
                return this.fileFoundOnContentServerFieldSpecified;
            }
            set
            {
                this.fileFoundOnContentServerFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public string fileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=2)]
        public Nullable<bool> isImageFile
        {
            get
            {
                return this.isImageFileField;
            }
            set
            {
                this.isImageFileField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool isImageFileSpecified
        {
            get
            {
                return this.isImageFileFieldSpecified;
            }
            set
            {
                this.isImageFileFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=3)]
        public Nullable<bool> isSvgFile
        {
            get
            {
                return this.isSvgFileField;
            }
            set
            {
                this.isSvgFileField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool isSvgFileSpecified
        {
            get
            {
                return this.isSvgFileFieldSpecified;
            }
            set
            {
                this.isSvgFileFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=4)]
        public Nullable<bool> svgImageReferenceFileFoundOnContentServer
        {
            get
            {
                return this.svgImageReferenceFileFoundOnContentServerField;
            }
            set
            {
                this.svgImageReferenceFileFoundOnContentServerField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool svgImageReferenceFileFoundOnContentServerSpecified
        {
            get
            {
                return this.svgImageReferenceFileFoundOnContentServerFieldSpecified;
            }
            set
            {
                this.svgImageReferenceFileFoundOnContentServerFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=5)]
        public Nullable<bool> svgImageReferenceFileProcessedByTileConverter
        {
            get
            {
                return this.svgImageReferenceFileProcessedByTileConverterField;
            }
            set
            {
                this.svgImageReferenceFileProcessedByTileConverterField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool svgImageReferenceFileProcessedByTileConverterSpecified
        {
            get
            {
                return this.svgImageReferenceFileProcessedByTileConverterFieldSpecified;
            }
            set
            {
                this.svgImageReferenceFileProcessedByTileConverterFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=6)]
        public string svgPrimaryImageFileName
        {
            get
            {
                return this.svgPrimaryImageFileNameField;
            }
            set
            {
                this.svgPrimaryImageFileNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://entity.dto.webservices.digabit.com/xsd")]
    public partial class TranslationDto : AbstractDto
    {
        
        private string descriptionField;
        
        private string languageCodeField;
        
        private string nameField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public string languageCode
        {
            get
            {
                return this.languageCodeField;
            }
            set
            {
                this.languageCodeField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=2)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [XmlIncludeAttribute(typeof(MediaCategoryDto))]
    [XmlIncludeAttribute(typeof(LightOrganizationDto))]
    [XmlIncludeAttribute(typeof(MediaDto))]
    [XmlIncludeAttribute(typeof(TranslationDto))]
    [XmlIncludeAttribute(typeof(PageDto))]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://entity.dto.webservices.digabit.com/xsd")]
    public partial class AbstractDto
    {
        
        private Nullable<DateTime> createDateField;
        
        private bool createDateFieldSpecified;
        
        private Nullable<DateTime> updateDateField;
        
        private bool updateDateFieldSpecified;
        
        private Nullable<int> versionField;
        
        private bool versionFieldSpecified;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public Nullable<DateTime> createDate
        {
            get
            {
                return this.createDateField;
            }
            set
            {
                this.createDateField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool createDateSpecified
        {
            get
            {
                return this.createDateFieldSpecified;
            }
            set
            {
                this.createDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public Nullable<DateTime> updateDate
        {
            get
            {
                return this.updateDateField;
            }
            set
            {
                this.updateDateField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool updateDateSpecified
        {
            get
            {
                return this.updateDateFieldSpecified;
            }
            set
            {
                this.updateDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=2)]
        public Nullable<int> version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool versionSpecified
        {
            get
            {
                return this.versionFieldSpecified;
            }
            set
            {
                this.versionFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://entity.dto.webservices.digabit.com/xsd")]
    public partial class MediaCategoryDto : AbstractDto
    {
        
        private string contactEmailField;
        
        private Nullable<int> displayOrderField;
        
        private bool displayOrderFieldSpecified;
        
        private string hashKeyField;
        
        private TranslationDto[] translationsField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public string contactEmail
        {
            get
            {
                return this.contactEmailField;
            }
            set
            {
                this.contactEmailField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public Nullable<int> displayOrder
        {
            get
            {
                return this.displayOrderField;
            }
            set
            {
                this.displayOrderField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool displayOrderSpecified
        {
            get
            {
                return this.displayOrderFieldSpecified;
            }
            set
            {
                this.displayOrderFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=2)]
        public string hashKey
        {
            get
            {
                return this.hashKeyField;
            }
            set
            {
                this.hashKeyField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute("translations", IsNullable=true, Order=3)]
        public TranslationDto[] translations
        {
            get
            {
                return this.translationsField;
            }
            set
            {
                this.translationsField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://entity.dto.webservices.digabit.com/xsd")]
    public partial class LightOrganizationDto : AbstractDto
    {
        
        private string nameField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://entity.dto.webservices.digabit.com/xsd")]
    public partial class MediaDto : AbstractDto
    {
        
        private string identifierField;
        
        private string mediaTypeField;
        
        private Nullable<bool> offlineEnabledField;
        
        private bool offlineEnabledFieldSpecified;
        
        private string offlineExpirationUnitField;
        
        private Nullable<int> offlineExpirationValueField;
        
        private bool offlineExpirationValueFieldSpecified;
        
        private string[] relatedMediaIdentifiersField;
        
        private TagDto[] tagsField;
        
        private string tenantKeyField;
        
        private TranslationDto[] translationsField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public string identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public string mediaType
        {
            get
            {
                return this.mediaTypeField;
            }
            set
            {
                this.mediaTypeField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=2)]
        public Nullable<bool> offlineEnabled
        {
            get
            {
                return this.offlineEnabledField;
            }
            set
            {
                this.offlineEnabledField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool offlineEnabledSpecified
        {
            get
            {
                return this.offlineEnabledFieldSpecified;
            }
            set
            {
                this.offlineEnabledFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=3)]
        public string offlineExpirationUnit
        {
            get
            {
                return this.offlineExpirationUnitField;
            }
            set
            {
                this.offlineExpirationUnitField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=4)]
        public Nullable<int> offlineExpirationValue
        {
            get
            {
                return this.offlineExpirationValueField;
            }
            set
            {
                this.offlineExpirationValueField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool offlineExpirationValueSpecified
        {
            get
            {
                return this.offlineExpirationValueFieldSpecified;
            }
            set
            {
                this.offlineExpirationValueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute("relatedMediaIdentifiers", IsNullable=true, Order=5)]
        public string[] relatedMediaIdentifiers
        {
            get
            {
                return this.relatedMediaIdentifiersField;
            }
            set
            {
                this.relatedMediaIdentifiersField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute("tags", IsNullable=true, Order=6)]
        public TagDto[] tags
        {
            get
            {
                return this.tagsField;
            }
            set
            {
                this.tagsField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=7)]
        public string tenantKey
        {
            get
            {
                return this.tenantKeyField;
            }
            set
            {
                this.tenantKeyField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute("translations", IsNullable=true, Order=8)]
        public TranslationDto[] translations
        {
            get
            {
                return this.translationsField;
            }
            set
            {
                this.translationsField = value;
            }
        }
    }
    
    /// <remarks/>
    [XmlIncludeAttribute(typeof(TagWithDateDto))]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://entity.dto.webservices.digabit.com/xsd")]
    public partial class TagDto
    {
        
        private Nullable<int> lowerBoundValueField;
        
        private bool lowerBoundValueFieldSpecified;
        
        private string prefixValueField;
        
        private string suffixValueField;
        
        private string tagNameField;
        
        private string tagValueField;
        
        private Nullable<int> upperBoundValueField;
        
        private bool upperBoundValueFieldSpecified;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public Nullable<int> lowerBoundValue
        {
            get
            {
                return this.lowerBoundValueField;
            }
            set
            {
                this.lowerBoundValueField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool lowerBoundValueSpecified
        {
            get
            {
                return this.lowerBoundValueFieldSpecified;
            }
            set
            {
                this.lowerBoundValueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public string prefixValue
        {
            get
            {
                return this.prefixValueField;
            }
            set
            {
                this.prefixValueField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=2)]
        public string suffixValue
        {
            get
            {
                return this.suffixValueField;
            }
            set
            {
                this.suffixValueField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=3)]
        public string tagName
        {
            get
            {
                return this.tagNameField;
            }
            set
            {
                this.tagNameField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=4)]
        public string tagValue
        {
            get
            {
                return this.tagValueField;
            }
            set
            {
                this.tagValueField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=5)]
        public Nullable<int> upperBoundValue
        {
            get
            {
                return this.upperBoundValueField;
            }
            set
            {
                this.upperBoundValueField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool upperBoundValueSpecified
        {
            get
            {
                return this.upperBoundValueFieldSpecified;
            }
            set
            {
                this.upperBoundValueFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://entity.dto.webservices.digabit.com/xsd")]
    public partial class TagWithDateDto : TagDto
    {
        
        private Nullable<DateTime> createDateField;
        
        private bool createDateFieldSpecified;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public Nullable<DateTime> createDate
        {
            get
            {
                return this.createDateField;
            }
            set
            {
                this.createDateField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool createDateSpecified
        {
            get
            {
                return this.createDateFieldSpecified;
            }
            set
            {
                this.createDateFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://entity.dto.webservices.digabit.com/xsd")]
    public partial class PageDto : AbstractDto
    {
        
        private string hashKeyField;
        
        private string pageFileField;
        
        private TranslationDto[] translationsField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public string hashKey
        {
            get
            {
                return this.hashKeyField;
            }
            set
            {
                this.hashKeyField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public string pageFile
        {
            get
            {
                return this.pageFileField;
            }
            set
            {
                this.pageFileField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute("translations", IsNullable=true, Order=2)]
        public TranslationDto[] translations
        {
            get
            {
                return this.translationsField;
            }
            set
            {
                this.translationsField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://entity.dto.webservices.digabit.com/xsd")]
    public partial class ChapterValidationBeanDto
    {
        
        private PageFileValidationBeanDto pageFileValidationBeanDtoField;
        
        private TranslationDto[] translationsField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public PageFileValidationBeanDto pageFileValidationBeanDto
        {
            get
            {
                return this.pageFileValidationBeanDtoField;
            }
            set
            {
                this.pageFileValidationBeanDtoField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute("translations", IsNullable=true, Order=1)]
        public TranslationDto[] translations
        {
            get
            {
                return this.translationsField;
            }
            set
            {
                this.translationsField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://dto.webservices.digabit.com/xsd")]
    public partial class ResultMessageDto
    {
        
        private string messageField;
        
        private string nameField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public string message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [XmlIncludeAttribute(typeof(FetchSuppliersResponseDto))]
    [XmlIncludeAttribute(typeof(UpdateLocationDataResponseDto))]
    [XmlIncludeAttribute(typeof(ValidateBookContentResponseDto))]
    [XmlIncludeAttribute(typeof(SetAccessControlsResponseDto))]
    [XmlIncludeAttribute(typeof(UpdatePartResponseDto))]
    [XmlIncludeAttribute(typeof(FetchPartResponseDto))]
    [XmlIncludeAttribute(typeof(PartLookupResponseDto))]
    [XmlIncludeAttribute(typeof(GetJobStatusResponseDto))]
    [XmlIncludeAttribute(typeof(PublishFilesResponseDto))]
    [XmlIncludeAttribute(typeof(GetUploadedFilesListResponseDto))]
    [XmlIncludeAttribute(typeof(BooleanResponseDto))]
    [XmlIncludeAttribute(typeof(FetchMediaShelvesForMediaResponseDto))]
    [XmlIncludeAttribute(typeof(FetchOrganizationAccessForMediaResponseDto))]
    [XmlIncludeAttribute(typeof(AbstractPaginatedResponseDto))]
    [XmlIncludeAttribute(typeof(FetchMediaIdentifiersResponseDto))]
    [XmlIncludeAttribute(typeof(FetchTagsForMediaResponseDto))]
    [XmlIncludeAttribute(typeof(FetchTagValuesForMediaByTagNameResponseDto))]
    [XmlIncludeAttribute(typeof(DeleteTagValuesForTagNameOnMediaResponseDto))]
    [XmlIncludeAttribute(typeof(FetchMediaResponseDto))]
    [XmlIncludeAttribute(typeof(ExportMediaResponseDto))]
    [XmlIncludeAttribute(typeof(UpdatePagePartTagsResponseDto))]
    [XmlIncludeAttribute(typeof(UploadFileToBePublishedResponseDto))]
    [XmlIncludeAttribute(typeof(SupersedePartResponseDto))]
    [XmlIncludeAttribute(typeof(UpdateMediaResponseDto))]
    [XmlIncludeAttribute(typeof(ValidatePageFileResponseDto))]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://response.dto.webservices.digabit.com/xsd")]
    public partial class AbstractResponseDto
    {
        
        private Nullable<int> responseCodeField;
        
        private bool responseCodeFieldSpecified;
        
        private string responseMessageField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public Nullable<int> responseCode
        {
            get
            {
                return this.responseCodeField;
            }
            set
            {
                this.responseCodeField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool responseCodeSpecified
        {
            get
            {
                return this.responseCodeFieldSpecified;
            }
            set
            {
                this.responseCodeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public string responseMessage
        {
            get
            {
                return this.responseMessageField;
            }
            set
            {
                this.responseMessageField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://response.dto.webservices.digabit.com/xsd")]
    public partial class FetchSuppliersResponseDto : AbstractResponseDto
    {
        
        private FetchSuppliersRequestDto requestField;
        
        private string[] supplierCodesField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public FetchSuppliersRequestDto request
        {
            get
            {
                return this.requestField;
            }
            set
            {
                this.requestField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute("supplierCodes", IsNullable=true, Order=1)]
        public string[] supplierCodes
        {
            get
            {
                return this.supplierCodesField;
            }
            set
            {
                this.supplierCodesField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://request.dto.webservices.digabit.com/xsd")]
    public partial class FetchSuppliersRequestDto : AbstractRequestDto
    {
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://response.dto.webservices.digabit.com/xsd")]
    public partial class UpdateLocationDataResponseDto : AbstractResponseDto
    {
        
        private Nullable<int> numberOfPartRecordsUpdatedField;
        
        private bool numberOfPartRecordsUpdatedFieldSpecified;
        
        private UpdateLocationDataRequestDto requestField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public Nullable<int> numberOfPartRecordsUpdated
        {
            get
            {
                return this.numberOfPartRecordsUpdatedField;
            }
            set
            {
                this.numberOfPartRecordsUpdatedField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool numberOfPartRecordsUpdatedSpecified
        {
            get
            {
                return this.numberOfPartRecordsUpdatedFieldSpecified;
            }
            set
            {
                this.numberOfPartRecordsUpdatedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public UpdateLocationDataRequestDto request
        {
            get
            {
                return this.requestField;
            }
            set
            {
                this.requestField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://request.dto.webservices.digabit.com/xsd")]
    public partial class UpdateLocationDataRequestDto : AbstractRequestDto
    {
        
        private string partNumberField;
        
        private string partTagNameField;
        
        private string partTagValueField;
        
        private Nullable<bool> replaceAllStockLocationDataField;
        
        private bool replaceAllStockLocationDataFieldSpecified;
        
        private PartStockLocationDto[] stockLocationDataField;
        
        private string supplierKeyField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public string partNumber
        {
            get
            {
                return this.partNumberField;
            }
            set
            {
                this.partNumberField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public string partTagName
        {
            get
            {
                return this.partTagNameField;
            }
            set
            {
                this.partTagNameField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=2)]
        public string partTagValue
        {
            get
            {
                return this.partTagValueField;
            }
            set
            {
                this.partTagValueField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=3)]
        public Nullable<bool> replaceAllStockLocationData
        {
            get
            {
                return this.replaceAllStockLocationDataField;
            }
            set
            {
                this.replaceAllStockLocationDataField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool replaceAllStockLocationDataSpecified
        {
            get
            {
                return this.replaceAllStockLocationDataFieldSpecified;
            }
            set
            {
                this.replaceAllStockLocationDataFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute("stockLocationData", IsNullable=true, Order=4)]
        public PartStockLocationDto[] stockLocationData
        {
            get
            {
                return this.stockLocationDataField;
            }
            set
            {
                this.stockLocationDataField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=5)]
        public string supplierKey
        {
            get
            {
                return this.supplierKeyField;
            }
            set
            {
                this.supplierKeyField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://entity.dto.webservices.digabit.com/xsd")]
    public partial class PartStockLocationDto
    {
        
        private string binNumberField;
        
        private Nullable<int> leadTimeDaysField;
        
        private bool leadTimeDaysFieldSpecified;
        
        private Nullable<int> quantityOnHandField;
        
        private bool quantityOnHandFieldSpecified;
        
        private string stockLocationKeyField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public string binNumber
        {
            get
            {
                return this.binNumberField;
            }
            set
            {
                this.binNumberField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public Nullable<int> leadTimeDays
        {
            get
            {
                return this.leadTimeDaysField;
            }
            set
            {
                this.leadTimeDaysField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool leadTimeDaysSpecified
        {
            get
            {
                return this.leadTimeDaysFieldSpecified;
            }
            set
            {
                this.leadTimeDaysFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=2)]
        public Nullable<int> quantityOnHand
        {
            get
            {
                return this.quantityOnHandField;
            }
            set
            {
                this.quantityOnHandField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool quantityOnHandSpecified
        {
            get
            {
                return this.quantityOnHandFieldSpecified;
            }
            set
            {
                this.quantityOnHandFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=3)]
        public string stockLocationKey
        {
            get
            {
                return this.stockLocationKeyField;
            }
            set
            {
                this.stockLocationKeyField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://response.dto.webservices.digabit.com/xsd")]
    public partial class ValidateBookContentResponseDto : AbstractResponseDto
    {
        
        private Nullable<int> chapterCountField;
        
        private bool chapterCountFieldSpecified;
        
        private ChapterValidationBeanDto[] chapterValidationBeansField;
        
        private string[] mediaCategoriesField;
        
        private string[] organizationsField;
        
        private Nullable<int> pageCountField;
        
        private bool pageCountFieldSpecified;
        
        private string[] pageFilesMissingFromContentServerField;
        
        private PageValidationBeanDto[] pageValidationBeansField;
        
        private ValidateBookContentRequestDto requestField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public Nullable<int> chapterCount
        {
            get
            {
                return this.chapterCountField;
            }
            set
            {
                this.chapterCountField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool chapterCountSpecified
        {
            get
            {
                return this.chapterCountFieldSpecified;
            }
            set
            {
                this.chapterCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute("chapterValidationBeans", IsNullable=true, Order=1)]
        public ChapterValidationBeanDto[] chapterValidationBeans
        {
            get
            {
                return this.chapterValidationBeansField;
            }
            set
            {
                this.chapterValidationBeansField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute("mediaCategories", IsNullable=true, Order=2)]
        public string[] mediaCategories
        {
            get
            {
                return this.mediaCategoriesField;
            }
            set
            {
                this.mediaCategoriesField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute("organizations", IsNullable=true, Order=3)]
        public string[] organizations
        {
            get
            {
                return this.organizationsField;
            }
            set
            {
                this.organizationsField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=4)]
        public Nullable<int> pageCount
        {
            get
            {
                return this.pageCountField;
            }
            set
            {
                this.pageCountField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool pageCountSpecified
        {
            get
            {
                return this.pageCountFieldSpecified;
            }
            set
            {
                this.pageCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute("pageFilesMissingFromContentServer", IsNullable=true, Order=5)]
        public string[] pageFilesMissingFromContentServer
        {
            get
            {
                return this.pageFilesMissingFromContentServerField;
            }
            set
            {
                this.pageFilesMissingFromContentServerField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute("pageValidationBeans", IsNullable=true, Order=6)]
        public PageValidationBeanDto[] pageValidationBeans
        {
            get
            {
                return this.pageValidationBeansField;
            }
            set
            {
                this.pageValidationBeansField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=7)]
        public ValidateBookContentRequestDto request
        {
            get
            {
                return this.requestField;
            }
            set
            {
                this.requestField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://request.dto.webservices.digabit.com/xsd")]
    public partial class ValidateBookContentRequestDto : AbstractRequestDto
    {
        
        private Nullable<bool> includeAllContentValidationBeansField;
        
        private bool includeAllContentValidationBeansFieldSpecified;
        
        private string mediaIdentifierField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public Nullable<bool> includeAllContentValidationBeans
        {
            get
            {
                return this.includeAllContentValidationBeansField;
            }
            set
            {
                this.includeAllContentValidationBeansField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool includeAllContentValidationBeansSpecified
        {
            get
            {
                return this.includeAllContentValidationBeansFieldSpecified;
            }
            set
            {
                this.includeAllContentValidationBeansFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public string mediaIdentifier
        {
            get
            {
                return this.mediaIdentifierField;
            }
            set
            {
                this.mediaIdentifierField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://response.dto.webservices.digabit.com/xsd")]
    public partial class SetAccessControlsResponseDto : AbstractResponseDto
    {
        
        private SetAccessControlsRequestDto requestField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public SetAccessControlsRequestDto request
        {
            get
            {
                return this.requestField;
            }
            set
            {
                this.requestField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://request.dto.webservices.digabit.com/xsd")]
    public partial class SetAccessControlsRequestDto : AbstractRequestDto
    {
        
        private string mediaIdentifierField;
        
        private string[] mediacategoryNamesField;
        
        private string[] organizationNamesField;
        
        private Nullable<bool> replaceAllMediaCategoriesField;
        
        private bool replaceAllMediaCategoriesFieldSpecified;
        
        private Nullable<bool> replaceAllOrganizationsField;
        
        private bool replaceAllOrganizationsFieldSpecified;
        
        private string userNameField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public string mediaIdentifier
        {
            get
            {
                return this.mediaIdentifierField;
            }
            set
            {
                this.mediaIdentifierField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute("mediacategoryNames", IsNullable=true, Order=1)]
        public string[] mediacategoryNames
        {
            get
            {
                return this.mediacategoryNamesField;
            }
            set
            {
                this.mediacategoryNamesField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute("organizationNames", IsNullable=true, Order=2)]
        public string[] organizationNames
        {
            get
            {
                return this.organizationNamesField;
            }
            set
            {
                this.organizationNamesField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=3)]
        public Nullable<bool> replaceAllMediaCategories
        {
            get
            {
                return this.replaceAllMediaCategoriesField;
            }
            set
            {
                this.replaceAllMediaCategoriesField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool replaceAllMediaCategoriesSpecified
        {
            get
            {
                return this.replaceAllMediaCategoriesFieldSpecified;
            }
            set
            {
                this.replaceAllMediaCategoriesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=4)]
        public Nullable<bool> replaceAllOrganizations
        {
            get
            {
                return this.replaceAllOrganizationsField;
            }
            set
            {
                this.replaceAllOrganizationsField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool replaceAllOrganizationsSpecified
        {
            get
            {
                return this.replaceAllOrganizationsFieldSpecified;
            }
            set
            {
                this.replaceAllOrganizationsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=5)]
        public string userName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://response.dto.webservices.digabit.com/xsd")]
    public partial class UpdatePartResponseDto : AbstractResponseDto
    {
        
        private UpdatePartRequestDto requestField;
        
        private PartDto updatedPartField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public UpdatePartRequestDto request
        {
            get
            {
                return this.requestField;
            }
            set
            {
                this.requestField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public PartDto updatedPart
        {
            get
            {
                return this.updatedPartField;
            }
            set
            {
                this.updatedPartField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://request.dto.webservices.digabit.com/xsd")]
    public partial class UpdatePartRequestDto : AbstractRequestDto
    {
        
        private string hashKeyField;
        
        private PartDto newPartDataField;
        
        private string partNumberField;
        
        private string partTagNameField;
        
        private string partTagValueField;
        
        private Nullable<bool> replaceAllPartTagsField;
        
        private bool replaceAllPartTagsFieldSpecified;
        
        private string supplierKeyField;
        
        private string userNameField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public string hashKey
        {
            get
            {
                return this.hashKeyField;
            }
            set
            {
                this.hashKeyField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public PartDto newPartData
        {
            get
            {
                return this.newPartDataField;
            }
            set
            {
                this.newPartDataField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=2)]
        public string partNumber
        {
            get
            {
                return this.partNumberField;
            }
            set
            {
                this.partNumberField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=3)]
        public string partTagName
        {
            get
            {
                return this.partTagNameField;
            }
            set
            {
                this.partTagNameField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=4)]
        public string partTagValue
        {
            get
            {
                return this.partTagValueField;
            }
            set
            {
                this.partTagValueField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=5)]
        public Nullable<bool> replaceAllPartTags
        {
            get
            {
                return this.replaceAllPartTagsField;
            }
            set
            {
                this.replaceAllPartTagsField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool replaceAllPartTagsSpecified
        {
            get
            {
                return this.replaceAllPartTagsFieldSpecified;
            }
            set
            {
                this.replaceAllPartTagsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=6)]
        public string supplierKey
        {
            get
            {
                return this.supplierKeyField;
            }
            set
            {
                this.supplierKeyField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=7)]
        public string userName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://entity.dto.webservices.digabit.com/xsd")]
    public partial class PartDto
    {
        
        private Nullable<double> discountedPriceField;
        
        private bool discountedPriceFieldSpecified;
        
        private string hashKeyField;
        
        private Nullable<bool> orderableField;
        
        private bool orderableFieldSpecified;
        
        private string partNameField;
        
        private string partNumberField;
        
        private Nullable<bool> partNumberVisibleField;
        
        private bool partNumberVisibleFieldSpecified;
        
        private OrganizationPartPricingDto[] partPricingsField;
        
        private Nullable<double> retailPriceField;
        
        private bool retailPriceFieldSpecified;
        
        private string supplierKeyField;
        
        private TagDto[] tagsField;
        
        private TranslationDto[] translationsField;
        
        private string unitOfMeasureField;
        
        private Nullable<double> wholesalePriceField;
        
        private bool wholesalePriceFieldSpecified;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public Nullable<double> discountedPrice
        {
            get
            {
                return this.discountedPriceField;
            }
            set
            {
                this.discountedPriceField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool discountedPriceSpecified
        {
            get
            {
                return this.discountedPriceFieldSpecified;
            }
            set
            {
                this.discountedPriceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public string hashKey
        {
            get
            {
                return this.hashKeyField;
            }
            set
            {
                this.hashKeyField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=2)]
        public Nullable<bool> orderable
        {
            get
            {
                return this.orderableField;
            }
            set
            {
                this.orderableField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool orderableSpecified
        {
            get
            {
                return this.orderableFieldSpecified;
            }
            set
            {
                this.orderableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=3)]
        public string partName
        {
            get
            {
                return this.partNameField;
            }
            set
            {
                this.partNameField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=4)]
        public string partNumber
        {
            get
            {
                return this.partNumberField;
            }
            set
            {
                this.partNumberField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=5)]
        public Nullable<bool> partNumberVisible
        {
            get
            {
                return this.partNumberVisibleField;
            }
            set
            {
                this.partNumberVisibleField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool partNumberVisibleSpecified
        {
            get
            {
                return this.partNumberVisibleFieldSpecified;
            }
            set
            {
                this.partNumberVisibleFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute("partPricings", IsNullable=true, Order=6)]
        public OrganizationPartPricingDto[] partPricings
        {
            get
            {
                return this.partPricingsField;
            }
            set
            {
                this.partPricingsField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=7)]
        public Nullable<double> retailPrice
        {
            get
            {
                return this.retailPriceField;
            }
            set
            {
                this.retailPriceField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool retailPriceSpecified
        {
            get
            {
                return this.retailPriceFieldSpecified;
            }
            set
            {
                this.retailPriceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=8)]
        public string supplierKey
        {
            get
            {
                return this.supplierKeyField;
            }
            set
            {
                this.supplierKeyField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute("tags", IsNullable=true, Order=9)]
        public TagDto[] tags
        {
            get
            {
                return this.tagsField;
            }
            set
            {
                this.tagsField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute("translations", IsNullable=true, Order=10)]
        public TranslationDto[] translations
        {
            get
            {
                return this.translationsField;
            }
            set
            {
                this.translationsField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=11)]
        public string unitOfMeasure
        {
            get
            {
                return this.unitOfMeasureField;
            }
            set
            {
                this.unitOfMeasureField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=12)]
        public Nullable<double> wholesalePrice
        {
            get
            {
                return this.wholesalePriceField;
            }
            set
            {
                this.wholesalePriceField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool wholesalePriceSpecified
        {
            get
            {
                return this.wholesalePriceFieldSpecified;
            }
            set
            {
                this.wholesalePriceFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://entity.dto.webservices.digabit.com/xsd")]
    public partial class OrganizationPartPricingDto
    {
        
        private Nullable<double> discountedPriceField;
        
        private bool discountedPriceFieldSpecified;
        
        private string organizationNameField;
        
        private Nullable<double> retailPriceField;
        
        private bool retailPriceFieldSpecified;
        
        private Nullable<double> wholesalePriceField;
        
        private bool wholesalePriceFieldSpecified;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public Nullable<double> discountedPrice
        {
            get
            {
                return this.discountedPriceField;
            }
            set
            {
                this.discountedPriceField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool discountedPriceSpecified
        {
            get
            {
                return this.discountedPriceFieldSpecified;
            }
            set
            {
                this.discountedPriceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public string organizationName
        {
            get
            {
                return this.organizationNameField;
            }
            set
            {
                this.organizationNameField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=2)]
        public Nullable<double> retailPrice
        {
            get
            {
                return this.retailPriceField;
            }
            set
            {
                this.retailPriceField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool retailPriceSpecified
        {
            get
            {
                return this.retailPriceFieldSpecified;
            }
            set
            {
                this.retailPriceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=3)]
        public Nullable<double> wholesalePrice
        {
            get
            {
                return this.wholesalePriceField;
            }
            set
            {
                this.wholesalePriceField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool wholesalePriceSpecified
        {
            get
            {
                return this.wholesalePriceFieldSpecified;
            }
            set
            {
                this.wholesalePriceFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://response.dto.webservices.digabit.com/xsd")]
    public partial class FetchPartResponseDto : AbstractResponseDto
    {
        
        private PartDto[] partsFoundField;
        
        private FetchPartRequestDto requestField;
        
        private Nullable<int> totalField;
        
        private bool totalFieldSpecified;
        
        /// <remarks/>
        [XmlElementAttribute("partsFound", IsNullable=true, Order=0)]
        public PartDto[] partsFound
        {
            get
            {
                return this.partsFoundField;
            }
            set
            {
                this.partsFoundField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public FetchPartRequestDto request
        {
            get
            {
                return this.requestField;
            }
            set
            {
                this.requestField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=2)]
        public Nullable<int> total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool totalSpecified
        {
            get
            {
                return this.totalFieldSpecified;
            }
            set
            {
                this.totalFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://request.dto.webservices.digabit.com/xsd")]
    public partial class FetchPartRequestDto : AbstractRequestDto
    {
        
        private Nullable<int> limitField;
        
        private bool limitFieldSpecified;
        
        private string partNumberField;
        
        private string partTagNameField;
        
        private string partTagValueField;
        
        private Nullable<int> startField;
        
        private bool startFieldSpecified;
        
        private string supplierKeyField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public Nullable<int> limit
        {
            get
            {
                return this.limitField;
            }
            set
            {
                this.limitField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool limitSpecified
        {
            get
            {
                return this.limitFieldSpecified;
            }
            set
            {
                this.limitFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public string partNumber
        {
            get
            {
                return this.partNumberField;
            }
            set
            {
                this.partNumberField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=2)]
        public string partTagName
        {
            get
            {
                return this.partTagNameField;
            }
            set
            {
                this.partTagNameField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=3)]
        public string partTagValue
        {
            get
            {
                return this.partTagValueField;
            }
            set
            {
                this.partTagValueField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=4)]
        public Nullable<int> start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool startSpecified
        {
            get
            {
                return this.startFieldSpecified;
            }
            set
            {
                this.startFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=5)]
        public string supplierKey
        {
            get
            {
                return this.supplierKeyField;
            }
            set
            {
                this.supplierKeyField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://response.dto.webservices.digabit.com/xsd")]
    public partial class PartLookupResponseDto : AbstractResponseDto
    {
        
        private PartDto[] partsField;
        
        private PartLookupRequestDto requestField;
        
        /// <remarks/>
        [XmlElementAttribute("parts", IsNullable=true, Order=0)]
        public PartDto[] parts
        {
            get
            {
                return this.partsField;
            }
            set
            {
                this.partsField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public PartLookupRequestDto request
        {
            get
            {
                return this.requestField;
            }
            set
            {
                this.requestField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://request.dto.webservices.digabit.com/xsd")]
    public partial class PartLookupRequestDto : AbstractRequestDto
    {
        
        private string netGeometryIdField;
        
        private string partNumberField;
        
        private string supplierKeyField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public string netGeometryId
        {
            get
            {
                return this.netGeometryIdField;
            }
            set
            {
                this.netGeometryIdField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public string partNumber
        {
            get
            {
                return this.partNumberField;
            }
            set
            {
                this.partNumberField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=2)]
        public string supplierKey
        {
            get
            {
                return this.supplierKeyField;
            }
            set
            {
                this.supplierKeyField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://response.dto.webservices.digabit.com/xsd")]
    public partial class GetJobStatusResponseDto : AbstractResponseDto
    {
        
        private string[] jobMessagesField;
        
        private string jobStatusField;
        
        private GetJobStatusRequestDto requestField;
        
        /// <remarks/>
        [XmlElementAttribute("jobMessages", IsNullable=true, Order=0)]
        public string[] jobMessages
        {
            get
            {
                return this.jobMessagesField;
            }
            set
            {
                this.jobMessagesField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public string jobStatus
        {
            get
            {
                return this.jobStatusField;
            }
            set
            {
                this.jobStatusField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=2)]
        public GetJobStatusRequestDto request
        {
            get
            {
                return this.requestField;
            }
            set
            {
                this.requestField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://request.dto.webservices.digabit.com/xsd")]
    public partial class GetJobStatusRequestDto : AbstractRequestDto
    {
        
        private string jobIdField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public string jobId
        {
            get
            {
                return this.jobIdField;
            }
            set
            {
                this.jobIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://response.dto.webservices.digabit.com/xsd")]
    public partial class PublishFilesResponseDto : AbstractResponseDto
    {
        
        private PublishFilesRequestDto requestField;
        
        private string[] submittedJobIdsField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public PublishFilesRequestDto request
        {
            get
            {
                return this.requestField;
            }
            set
            {
                this.requestField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute("submittedJobIds", IsNullable=true, Order=1)]
        public string[] submittedJobIds
        {
            get
            {
                return this.submittedJobIdsField;
            }
            set
            {
                this.submittedJobIdsField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://request.dto.webservices.digabit.com/xsd")]
    public partial class PublishFilesRequestDto : AbstractRequestDto
    {
        
        private string[] fileNamesField;
        
        private Nullable<bool> publishAllFilesField;
        
        private bool publishAllFilesFieldSpecified;
        
        private string userNameField;
        
        /// <remarks/>
        [XmlElementAttribute("fileNames", IsNullable=true, Order=0)]
        public string[] fileNames
        {
            get
            {
                return this.fileNamesField;
            }
            set
            {
                this.fileNamesField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public Nullable<bool> publishAllFiles
        {
            get
            {
                return this.publishAllFilesField;
            }
            set
            {
                this.publishAllFilesField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool publishAllFilesSpecified
        {
            get
            {
                return this.publishAllFilesFieldSpecified;
            }
            set
            {
                this.publishAllFilesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=2)]
        public string userName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://response.dto.webservices.digabit.com/xsd")]
    public partial class GetUploadedFilesListResponseDto : AbstractResponseDto
    {
        
        private string[] fileNamesField;
        
        private GetUploadedFilesListRequestDto requestField;
        
        /// <remarks/>
        [XmlElementAttribute("fileNames", IsNullable=true, Order=0)]
        public string[] fileNames
        {
            get
            {
                return this.fileNamesField;
            }
            set
            {
                this.fileNamesField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public GetUploadedFilesListRequestDto request
        {
            get
            {
                return this.requestField;
            }
            set
            {
                this.requestField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://request.dto.webservices.digabit.com/xsd")]
    public partial class GetUploadedFilesListRequestDto : AbstractRequestDto
    {
        
        private string filenameFilterField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public string filenameFilter
        {
            get
            {
                return this.filenameFilterField;
            }
            set
            {
                this.filenameFilterField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://response.dto.webservices.digabit.com/xsd")]
    public partial class BooleanResponseDto : AbstractResponseDto
    {
        
        private AbstractRequestDto requestField;
        
        private bool successField;
        
        private bool successFieldSpecified;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public AbstractRequestDto request
        {
            get
            {
                return this.requestField;
            }
            set
            {
                this.requestField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(Order=1)]
        public bool success
        {
            get
            {
                return this.successField;
            }
            set
            {
                this.successField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool successSpecified
        {
            get
            {
                return this.successFieldSpecified;
            }
            set
            {
                this.successFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://response.dto.webservices.digabit.com/xsd")]
    public partial class FetchMediaShelvesForMediaResponseDto : AbstractResponseDto
    {
        
        private MediaCategoryDto[] mediaShelvesField;
        
        private FetchMediaRequestDto requestField;
        
        /// <remarks/>
        [XmlElementAttribute("mediaShelves", IsNullable=true, Order=0)]
        public MediaCategoryDto[] mediaShelves
        {
            get
            {
                return this.mediaShelvesField;
            }
            set
            {
                this.mediaShelvesField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public FetchMediaRequestDto request
        {
            get
            {
                return this.requestField;
            }
            set
            {
                this.requestField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://request.dto.webservices.digabit.com/xsd")]
    public partial class FetchMediaRequestDto : AbstractRequestDto
    {
        
        private string identifierField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public string identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://response.dto.webservices.digabit.com/xsd")]
    public partial class FetchOrganizationAccessForMediaResponseDto : AbstractResponseDto
    {
        
        private LightOrganizationDto[] organizationsField;
        
        private FetchMediaRequestDto requestField;
        
        /// <remarks/>
        [XmlElementAttribute("organizations", IsNullable=true, Order=0)]
        public LightOrganizationDto[] organizations
        {
            get
            {
                return this.organizationsField;
            }
            set
            {
                this.organizationsField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public FetchMediaRequestDto request
        {
            get
            {
                return this.requestField;
            }
            set
            {
                this.requestField = value;
            }
        }
    }
    
    /// <remarks/>
    [XmlIncludeAttribute(typeof(FetchMediaIdentifiersResponseDto))]
    [XmlIncludeAttribute(typeof(FetchTagsForMediaResponseDto))]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://response.dto.webservices.digabit.com/xsd")]
    public partial class AbstractPaginatedResponseDto : AbstractResponseDto
    {
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://response.dto.webservices.digabit.com/xsd")]
    public partial class FetchMediaIdentifiersResponseDto : AbstractPaginatedResponseDto
    {
        
        private string[] identifiersField;
        
        private FetchMediaIdentifiersRequestDto requestField;
        
        private ResultMessageDto[] resultsField;
        
        /// <remarks/>
        [XmlElementAttribute("identifiers", IsNullable=true, Order=0)]
        public string[] identifiers
        {
            get
            {
                return this.identifiersField;
            }
            set
            {
                this.identifiersField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public FetchMediaIdentifiersRequestDto request
        {
            get
            {
                return this.requestField;
            }
            set
            {
                this.requestField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute("results", IsNullable=true, Order=2)]
        public ResultMessageDto[] results
        {
            get
            {
                return this.resultsField;
            }
            set
            {
                this.resultsField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://request.dto.webservices.digabit.com/xsd")]
    public partial class FetchMediaIdentifiersRequestDto : AbstractPaginatedRequestDto
    {
        
        private FilterDto[] filtersField;
        
        private string[] languageCode4sField;
        
        private string userNameField;
        
        /// <remarks/>
        [XmlElementAttribute("filters", IsNullable=true, Order=0)]
        public FilterDto[] filters
        {
            get
            {
                return this.filtersField;
            }
            set
            {
                this.filtersField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute("languageCode4s", IsNullable=true, Order=1)]
        public string[] languageCode4s
        {
            get
            {
                return this.languageCode4sField;
            }
            set
            {
                this.languageCode4sField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=2)]
        public string userName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://dto.webservices.digabit.com/xsd")]
    public partial class FilterDto
    {
        
        private Nullable<DateTime> dateValueField;
        
        private bool dateValueFieldSpecified;
        
        private string nameField;
        
        private string operatorField;
        
        private string prefixField;
        
        private string suffixField;
        
        private string valueField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public Nullable<DateTime> dateValue
        {
            get
            {
                return this.dateValueField;
            }
            set
            {
                this.dateValueField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool dateValueSpecified
        {
            get
            {
                return this.dateValueFieldSpecified;
            }
            set
            {
                this.dateValueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=2)]
        public string @operator
        {
            get
            {
                return this.operatorField;
            }
            set
            {
                this.operatorField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=3)]
        public string prefix
        {
            get
            {
                return this.prefixField;
            }
            set
            {
                this.prefixField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=4)]
        public string suffix
        {
            get
            {
                return this.suffixField;
            }
            set
            {
                this.suffixField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=5)]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [XmlIncludeAttribute(typeof(FetchMediaIdentifiersRequestDto))]
    [XmlIncludeAttribute(typeof(FetchTagsForMediaRequestDto))]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://request.dto.webservices.digabit.com/xsd")]
    public partial class AbstractPaginatedRequestDto : AbstractRequestDto
    {
        
        private PaginationDto paginationField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public PaginationDto pagination
        {
            get
            {
                return this.paginationField;
            }
            set
            {
                this.paginationField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://dto.webservices.digabit.com/xsd")]
    public partial class PaginationDto
    {
        
        private Nullable<int> limitField;
        
        private bool limitFieldSpecified;
        
        private Nullable<int> startField;
        
        private bool startFieldSpecified;
        
        private Nullable<int> totalField;
        
        private bool totalFieldSpecified;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public Nullable<int> limit
        {
            get
            {
                return this.limitField;
            }
            set
            {
                this.limitField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool limitSpecified
        {
            get
            {
                return this.limitFieldSpecified;
            }
            set
            {
                this.limitFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public Nullable<int> start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool startSpecified
        {
            get
            {
                return this.startFieldSpecified;
            }
            set
            {
                this.startFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=2)]
        public Nullable<int> total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool totalSpecified
        {
            get
            {
                return this.totalFieldSpecified;
            }
            set
            {
                this.totalFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://request.dto.webservices.digabit.com/xsd")]
    public partial class FetchTagsForMediaRequestDto : AbstractPaginatedRequestDto
    {
        
        private string identifierField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public string identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://response.dto.webservices.digabit.com/xsd")]
    public partial class FetchTagsForMediaResponseDto : AbstractPaginatedResponseDto
    {
        
        private FetchTagsForMediaRequestDto requestField;
        
        private TagDto[] tagsField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public FetchTagsForMediaRequestDto request
        {
            get
            {
                return this.requestField;
            }
            set
            {
                this.requestField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute("tags", IsNullable=true, Order=1)]
        public TagDto[] tags
        {
            get
            {
                return this.tagsField;
            }
            set
            {
                this.tagsField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://response.dto.webservices.digabit.com/xsd")]
    public partial class FetchTagValuesForMediaByTagNameResponseDto : AbstractResponseDto
    {
        
        private FetchTagValuesForMediaByTagNameRequestDto requestField;
        
        private TagWithDateDto[] tagsField;
        
        private Nullable<long> totalField;
        
        private bool totalFieldSpecified;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public FetchTagValuesForMediaByTagNameRequestDto request
        {
            get
            {
                return this.requestField;
            }
            set
            {
                this.requestField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute("tags", IsNullable=true, Order=1)]
        public TagWithDateDto[] tags
        {
            get
            {
                return this.tagsField;
            }
            set
            {
                this.tagsField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=2)]
        public Nullable<long> total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool totalSpecified
        {
            get
            {
                return this.totalFieldSpecified;
            }
            set
            {
                this.totalFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://response.dto.webservices.digabit.com/xsd")]
    public partial class DeleteTagValuesForTagNameOnMediaResponseDto : AbstractResponseDto
    {
        
        private DeleteTagValuesForTagNameOnMediaRequestDto requestField;
        
        private Nullable<int> rowsDeletedField;
        
        private bool rowsDeletedFieldSpecified;
        
        private Nullable<bool> successField;
        
        private bool successFieldSpecified;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public DeleteTagValuesForTagNameOnMediaRequestDto request
        {
            get
            {
                return this.requestField;
            }
            set
            {
                this.requestField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public Nullable<int> rowsDeleted
        {
            get
            {
                return this.rowsDeletedField;
            }
            set
            {
                this.rowsDeletedField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool rowsDeletedSpecified
        {
            get
            {
                return this.rowsDeletedFieldSpecified;
            }
            set
            {
                this.rowsDeletedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=2)]
        public Nullable<bool> success
        {
            get
            {
                return this.successField;
            }
            set
            {
                this.successField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool successSpecified
        {
            get
            {
                return this.successFieldSpecified;
            }
            set
            {
                this.successFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://request.dto.webservices.digabit.com/xsd")]
    public partial class DeleteTagValuesForTagNameOnMediaRequestDto : AbstractRequestDto
    {
        
        private Nullable<bool> deleteAllTagValuesField;
        
        private bool deleteAllTagValuesFieldSpecified;
        
        private string mediaIdentiferField;
        
        private string tagNameField;
        
        private string[] tagValuesField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public Nullable<bool> deleteAllTagValues
        {
            get
            {
                return this.deleteAllTagValuesField;
            }
            set
            {
                this.deleteAllTagValuesField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool deleteAllTagValuesSpecified
        {
            get
            {
                return this.deleteAllTagValuesFieldSpecified;
            }
            set
            {
                this.deleteAllTagValuesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public string mediaIdentifer
        {
            get
            {
                return this.mediaIdentiferField;
            }
            set
            {
                this.mediaIdentiferField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=2)]
        public string tagName
        {
            get
            {
                return this.tagNameField;
            }
            set
            {
                this.tagNameField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute("tagValues", IsNullable=true, Order=3)]
        public string[] tagValues
        {
            get
            {
                return this.tagValuesField;
            }
            set
            {
                this.tagValuesField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://response.dto.webservices.digabit.com/xsd")]
    public partial class FetchMediaResponseDto : AbstractResponseDto
    {
        
        private MediaDto mediaField;
        
        private FetchMediaRequestDto requestField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public MediaDto media
        {
            get
            {
                return this.mediaField;
            }
            set
            {
                this.mediaField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public FetchMediaRequestDto request
        {
            get
            {
                return this.requestField;
            }
            set
            {
                this.requestField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://response.dto.webservices.digabit.com/xsd")]
    public partial class ExportMediaResponseDto : AbstractResponseDto
    {
        
        private ExportMediaRequestDto requestField;
        
        private byte[] responseFileField;
        
        private string responseFileNameField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public ExportMediaRequestDto request
        {
            get
            {
                return this.requestField;
            }
            set
            {
                this.requestField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(DataType="base64Binary", IsNullable=true, Order=1)]
        public byte[] responseFile
        {
            get
            {
                return this.responseFileField;
            }
            set
            {
                this.responseFileField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=2)]
        public string responseFileName
        {
            get
            {
                return this.responseFileNameField;
            }
            set
            {
                this.responseFileNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://request.dto.webservices.digabit.com/xsd")]
    public partial class ExportMediaRequestDto : AbstractRequestDto
    {
        
        private string identifierField;
        
        private Nullable<bool> includeImagesField;
        
        private bool includeImagesFieldSpecified;
        
        private string userNameField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public string identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public Nullable<bool> includeImages
        {
            get
            {
                return this.includeImagesField;
            }
            set
            {
                this.includeImagesField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool includeImagesSpecified
        {
            get
            {
                return this.includeImagesFieldSpecified;
            }
            set
            {
                this.includeImagesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=2)]
        public string userName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://response.dto.webservices.digabit.com/xsd")]
    public partial class UpdatePagePartTagsResponseDto : AbstractResponseDto
    {
        
        private UpdatePagePartTagsRequestDto requestField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public UpdatePagePartTagsRequestDto request
        {
            get
            {
                return this.requestField;
            }
            set
            {
                this.requestField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://request.dto.webservices.digabit.com/xsd")]
    public partial class UpdatePagePartTagsRequestDto : AbstractRequestDto
    {
        
        private string pageFileNameField;
        
        private string pageNameField;
        
        private string partNumberField;
        
        private Nullable<bool> replaceAllTagsField;
        
        private bool replaceAllTagsFieldSpecified;
        
        private string supplierKeyField;
        
        private TagDto[] tagsField;
        
        private string userNameField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public string pageFileName
        {
            get
            {
                return this.pageFileNameField;
            }
            set
            {
                this.pageFileNameField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public string pageName
        {
            get
            {
                return this.pageNameField;
            }
            set
            {
                this.pageNameField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=2)]
        public string partNumber
        {
            get
            {
                return this.partNumberField;
            }
            set
            {
                this.partNumberField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=3)]
        public Nullable<bool> replaceAllTags
        {
            get
            {
                return this.replaceAllTagsField;
            }
            set
            {
                this.replaceAllTagsField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool replaceAllTagsSpecified
        {
            get
            {
                return this.replaceAllTagsFieldSpecified;
            }
            set
            {
                this.replaceAllTagsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=4)]
        public string supplierKey
        {
            get
            {
                return this.supplierKeyField;
            }
            set
            {
                this.supplierKeyField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute("tags", IsNullable=true, Order=5)]
        public TagDto[] tags
        {
            get
            {
                return this.tagsField;
            }
            set
            {
                this.tagsField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=6)]
        public string userName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://response.dto.webservices.digabit.com/xsd")]
    public partial class UploadFileToBePublishedResponseDto : AbstractResponseDto
    {
        
        private string fileNameField;
        
        private string submittedJobIdField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public string fileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public string submittedJobId
        {
            get
            {
                return this.submittedJobIdField;
            }
            set
            {
                this.submittedJobIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://response.dto.webservices.digabit.com/xsd")]
    public partial class SupersedePartResponseDto : AbstractResponseDto
    {
        
        private SupersedePartRequestDto requestField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public SupersedePartRequestDto request
        {
            get
            {
                return this.requestField;
            }
            set
            {
                this.requestField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://request.dto.webservices.digabit.com/xsd")]
    public partial class SupersedePartRequestDto : AbstractRequestDto
    {
        
        private string partNumberField;
        
        private string supplierKeyField;
        
        private PartDto[] targetExistingPartsField;
        
        private string[] targetMediaIdentifiersField;
        
        private PartDto[] targetNewPartsField;
        
        private string userNameField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public string partNumber
        {
            get
            {
                return this.partNumberField;
            }
            set
            {
                this.partNumberField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public string supplierKey
        {
            get
            {
                return this.supplierKeyField;
            }
            set
            {
                this.supplierKeyField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute("targetExistingParts", IsNullable=true, Order=2)]
        public PartDto[] targetExistingParts
        {
            get
            {
                return this.targetExistingPartsField;
            }
            set
            {
                this.targetExistingPartsField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute("targetMediaIdentifiers", IsNullable=true, Order=3)]
        public string[] targetMediaIdentifiers
        {
            get
            {
                return this.targetMediaIdentifiersField;
            }
            set
            {
                this.targetMediaIdentifiersField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute("targetNewParts", IsNullable=true, Order=4)]
        public PartDto[] targetNewParts
        {
            get
            {
                return this.targetNewPartsField;
            }
            set
            {
                this.targetNewPartsField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=5)]
        public string userName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://response.dto.webservices.digabit.com/xsd")]
    public partial class UpdateMediaResponseDto : AbstractResponseDto
    {
        
        private UpdateMediaRequestDto requestField;
        
        private MediaDto updatedMediaField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public UpdateMediaRequestDto request
        {
            get
            {
                return this.requestField;
            }
            set
            {
                this.requestField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public MediaDto updatedMedia
        {
            get
            {
                return this.updatedMediaField;
            }
            set
            {
                this.updatedMediaField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://request.dto.webservices.digabit.com/xsd")]
    public partial class UpdateMediaRequestDto : AbstractRequestDto
    {
        
        private string identifierField;
        
        private Nullable<bool> offlineEnabledField;
        
        private bool offlineEnabledFieldSpecified;
        
        private string offlineExpirationUnitField;
        
        private Nullable<int> offlineExpirationValueField;
        
        private bool offlineExpirationValueFieldSpecified;
        
        private string[] relatedMediaIdentifiersField;
        
        private Nullable<bool> replaceAllRelatedMediaField;
        
        private bool replaceAllRelatedMediaFieldSpecified;
        
        private Nullable<bool> replaceAllTagsField;
        
        private bool replaceAllTagsFieldSpecified;
        
        private Nullable<bool> replaceAllTranslationsField;
        
        private bool replaceAllTranslationsFieldSpecified;
        
        private TagDto[] tagsField;
        
        private TranslationDto[] translationsField;
        
        private string userNameField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public string identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public Nullable<bool> offlineEnabled
        {
            get
            {
                return this.offlineEnabledField;
            }
            set
            {
                this.offlineEnabledField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool offlineEnabledSpecified
        {
            get
            {
                return this.offlineEnabledFieldSpecified;
            }
            set
            {
                this.offlineEnabledFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=2)]
        public string offlineExpirationUnit
        {
            get
            {
                return this.offlineExpirationUnitField;
            }
            set
            {
                this.offlineExpirationUnitField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=3)]
        public Nullable<int> offlineExpirationValue
        {
            get
            {
                return this.offlineExpirationValueField;
            }
            set
            {
                this.offlineExpirationValueField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool offlineExpirationValueSpecified
        {
            get
            {
                return this.offlineExpirationValueFieldSpecified;
            }
            set
            {
                this.offlineExpirationValueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute("relatedMediaIdentifiers", IsNullable=true, Order=4)]
        public string[] relatedMediaIdentifiers
        {
            get
            {
                return this.relatedMediaIdentifiersField;
            }
            set
            {
                this.relatedMediaIdentifiersField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=5)]
        public Nullable<bool> replaceAllRelatedMedia
        {
            get
            {
                return this.replaceAllRelatedMediaField;
            }
            set
            {
                this.replaceAllRelatedMediaField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool replaceAllRelatedMediaSpecified
        {
            get
            {
                return this.replaceAllRelatedMediaFieldSpecified;
            }
            set
            {
                this.replaceAllRelatedMediaFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=6)]
        public Nullable<bool> replaceAllTags
        {
            get
            {
                return this.replaceAllTagsField;
            }
            set
            {
                this.replaceAllTagsField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool replaceAllTagsSpecified
        {
            get
            {
                return this.replaceAllTagsFieldSpecified;
            }
            set
            {
                this.replaceAllTagsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=7)]
        public Nullable<bool> replaceAllTranslations
        {
            get
            {
                return this.replaceAllTranslationsField;
            }
            set
            {
                this.replaceAllTranslationsField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool replaceAllTranslationsSpecified
        {
            get
            {
                return this.replaceAllTranslationsFieldSpecified;
            }
            set
            {
                this.replaceAllTranslationsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute("tags", IsNullable=true, Order=8)]
        public TagDto[] tags
        {
            get
            {
                return this.tagsField;
            }
            set
            {
                this.tagsField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute("translations", IsNullable=true, Order=9)]
        public TranslationDto[] translations
        {
            get
            {
                return this.translationsField;
            }
            set
            {
                this.translationsField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=10)]
        public string userName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://response.dto.webservices.digabit.com/xsd")]
    public partial class ValidatePageFileResponseDto : AbstractResponseDto
    {
        
        private Nullable<bool> fileFoundOnContentServerField;
        
        private bool fileFoundOnContentServerFieldSpecified;
        
        private Nullable<bool> isSvgFileField;
        
        private bool isSvgFileFieldSpecified;
        
        private PageDto[] pagesLinkedToPageFileField;
        
        private ValidatePageFileRequestDto requestField;
        
        private Nullable<bool> svgImageReferenceFileFoundOnContentServerField;
        
        private bool svgImageReferenceFileFoundOnContentServerFieldSpecified;
        
        private Nullable<bool> svgImageReferenceFileProcessedByTileConverterField;
        
        private bool svgImageReferenceFileProcessedByTileConverterFieldSpecified;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public Nullable<bool> fileFoundOnContentServer
        {
            get
            {
                return this.fileFoundOnContentServerField;
            }
            set
            {
                this.fileFoundOnContentServerField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool fileFoundOnContentServerSpecified
        {
            get
            {
                return this.fileFoundOnContentServerFieldSpecified;
            }
            set
            {
                this.fileFoundOnContentServerFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public Nullable<bool> isSvgFile
        {
            get
            {
                return this.isSvgFileField;
            }
            set
            {
                this.isSvgFileField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool isSvgFileSpecified
        {
            get
            {
                return this.isSvgFileFieldSpecified;
            }
            set
            {
                this.isSvgFileFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute("pagesLinkedToPageFile", IsNullable=true, Order=2)]
        public PageDto[] pagesLinkedToPageFile
        {
            get
            {
                return this.pagesLinkedToPageFileField;
            }
            set
            {
                this.pagesLinkedToPageFileField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=3)]
        public ValidatePageFileRequestDto request
        {
            get
            {
                return this.requestField;
            }
            set
            {
                this.requestField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=4)]
        public Nullable<bool> svgImageReferenceFileFoundOnContentServer
        {
            get
            {
                return this.svgImageReferenceFileFoundOnContentServerField;
            }
            set
            {
                this.svgImageReferenceFileFoundOnContentServerField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool svgImageReferenceFileFoundOnContentServerSpecified
        {
            get
            {
                return this.svgImageReferenceFileFoundOnContentServerFieldSpecified;
            }
            set
            {
                this.svgImageReferenceFileFoundOnContentServerFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=5)]
        public Nullable<bool> svgImageReferenceFileProcessedByTileConverter
        {
            get
            {
                return this.svgImageReferenceFileProcessedByTileConverterField;
            }
            set
            {
                this.svgImageReferenceFileProcessedByTileConverterField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool svgImageReferenceFileProcessedByTileConverterSpecified
        {
            get
            {
                return this.svgImageReferenceFileProcessedByTileConverterFieldSpecified;
            }
            set
            {
                this.svgImageReferenceFileProcessedByTileConverterFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://request.dto.webservices.digabit.com/xsd")]
    public partial class ValidatePageFileRequestDto : AbstractRequestDto
    {
        
        private string pageFileField;
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=0)]
        public string pageFile
        {
            get
            {
                return this.pageFileField;
            }
            set
            {
                this.pageFileField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="http://request.dto.webservices.digabit.com/xsd")]
    public partial class UploadFileToBePublishedRequestDto : AbstractRequestDto
    {
        
        private byte[] dataHandlerField;
        
        private string fileNameField;
        
        private Nullable<bool> submitForPublishingField;
        
        private bool submitForPublishingFieldSpecified;
        
        private string userNameField;
        
        /// <remarks/>
        [XmlElementAttribute(DataType="base64Binary", IsNullable=true, Order=0)]
        public byte[] dataHandler
        {
            get
            {
                return this.dataHandlerField;
            }
            set
            {
                this.dataHandlerField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=1)]
        public string fileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=2)]
        public Nullable<bool> submitForPublishing
        {
            get
            {
                return this.submitForPublishingField;
            }
            set
            {
                this.submitForPublishingField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool submitForPublishingSpecified
        {
            get
            {
                return this.submitForPublishingFieldSpecified;
            }
            set
            {
                this.submitForPublishingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElementAttribute(IsNullable=true, Order=3)]
        public string userName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="fetchTagValuesForMediaByTagName", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class fetchTagValuesForMediaByTagNameRequest
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute(IsNullable=true)]
        public FetchTagValuesForMediaByTagNameRequestDto request;
        
        public fetchTagValuesForMediaByTagNameRequest()
        {
        }
        
        public fetchTagValuesForMediaByTagNameRequest(FetchTagValuesForMediaByTagNameRequestDto request)
        {
            this.request = request;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="fetchTagValuesForMediaByTagNameResponse", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class fetchTagValuesForMediaByTagNameResponse
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute(IsNullable=true)]
        public FetchTagValuesForMediaByTagNameResponseDto @return;
        
        public fetchTagValuesForMediaByTagNameResponse()
        {
        }
        
        public fetchTagValuesForMediaByTagNameResponse(FetchTagValuesForMediaByTagNameResponseDto @return)
        {
            this.@return = @return;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="fetchMediaIdentifiers", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class fetchMediaIdentifiersRequest
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute(IsNullable=true)]
        public FetchMediaIdentifiersRequestDto request;
        
        public fetchMediaIdentifiersRequest()
        {
        }
        
        public fetchMediaIdentifiersRequest(FetchMediaIdentifiersRequestDto request)
        {
            this.request = request;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="fetchMediaIdentifiersResponse", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class fetchMediaIdentifiersResponse
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute(IsNullable=true)]
        public FetchMediaIdentifiersResponseDto @return;
        
        public fetchMediaIdentifiersResponse()
        {
        }
        
        public fetchMediaIdentifiersResponse(FetchMediaIdentifiersResponseDto @return)
        {
            this.@return = @return;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="supersedePart", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class supersedePartRequest
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute(IsNullable=true)]
        public SupersedePartRequestDto request;
        
        public supersedePartRequest()
        {
        }
        
        public supersedePartRequest(SupersedePartRequestDto request)
        {
            this.request = request;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="supersedePartResponse", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class supersedePartResponse
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute(IsNullable=true)]
        public SupersedePartResponseDto @return;
        
        public supersedePartResponse()
        {
        }
        
        public supersedePartResponse(SupersedePartResponseDto @return)
        {
            this.@return = @return;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="updateMediaForBoolean", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class updateMediaForBooleanRequest
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute("requests", IsNullable=true)]
        public UpdateMediaRequestDto[] requests;
        
        public updateMediaForBooleanRequest()
        {
        }
        
        public updateMediaForBooleanRequest(UpdateMediaRequestDto[] requests)
        {
            this.requests = requests;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="updateMediaForBooleanResponse", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class updateMediaForBooleanResponse
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute("return", IsNullable=true)]
        public BooleanResponseDto[] @return;
        
        public updateMediaForBooleanResponse()
        {
        }
        
        public updateMediaForBooleanResponse(BooleanResponseDto[] @return)
        {
            this.@return = @return;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="setAccessControls", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class setAccessControlsRequest
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute("requests", IsNullable=true)]
        public SetAccessControlsRequestDto[] requests;
        
        public setAccessControlsRequest()
        {
        }
        
        public setAccessControlsRequest(SetAccessControlsRequestDto[] requests)
        {
            this.requests = requests;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="setAccessControlsResponse", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class setAccessControlsResponse
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute("return", IsNullable=true)]
        public SetAccessControlsResponseDto[] @return;
        
        public setAccessControlsResponse()
        {
        }
        
        public setAccessControlsResponse(SetAccessControlsResponseDto[] @return)
        {
            this.@return = @return;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="fetchOrganizationAccessForMedia", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class fetchOrganizationAccessForMediaRequest
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute("requests", IsNullable=true)]
        public FetchMediaRequestDto[] requests;
        
        public fetchOrganizationAccessForMediaRequest()
        {
        }
        
        public fetchOrganizationAccessForMediaRequest(FetchMediaRequestDto[] requests)
        {
            this.requests = requests;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="fetchOrganizationAccessForMediaResponse", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class fetchOrganizationAccessForMediaResponse
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute("return", IsNullable=true)]
        public FetchOrganizationAccessForMediaResponseDto[] @return;
        
        public fetchOrganizationAccessForMediaResponse()
        {
        }
        
        public fetchOrganizationAccessForMediaResponse(FetchOrganizationAccessForMediaResponseDto[] @return)
        {
            this.@return = @return;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="exportMedia", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class exportMediaRequest
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute(IsNullable=true)]
        public ExportMediaRequestDto request;
        
        public exportMediaRequest()
        {
        }
        
        public exportMediaRequest(ExportMediaRequestDto request)
        {
            this.request = request;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="exportMediaResponse", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class exportMediaResponse
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute(IsNullable=true)]
        public ExportMediaResponseDto @return;
        
        public exportMediaResponse()
        {
        }
        
        public exportMediaResponse(ExportMediaResponseDto @return)
        {
            this.@return = @return;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="fetchTagsForMedia", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class fetchTagsForMediaRequest
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute("requests", IsNullable=true)]
        public FetchTagsForMediaRequestDto[] requests;
        
        public fetchTagsForMediaRequest()
        {
        }
        
        public fetchTagsForMediaRequest(FetchTagsForMediaRequestDto[] requests)
        {
            this.requests = requests;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="fetchTagsForMediaResponse", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class fetchTagsForMediaResponse
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute("return", IsNullable=true)]
        public FetchTagsForMediaResponseDto[] @return;
        
        public fetchTagsForMediaResponse()
        {
        }
        
        public fetchTagsForMediaResponse(FetchTagsForMediaResponseDto[] @return)
        {
            this.@return = @return;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="validateBookContent", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class validateBookContentRequest
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute(IsNullable=true)]
        public ValidateBookContentRequestDto request;
        
        public validateBookContentRequest()
        {
        }
        
        public validateBookContentRequest(ValidateBookContentRequestDto request)
        {
            this.request = request;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="validateBookContentResponse", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class validateBookContentResponse
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute(IsNullable=true)]
        public ValidateBookContentResponseDto @return;
        
        public validateBookContentResponse()
        {
        }
        
        public validateBookContentResponse(ValidateBookContentResponseDto @return)
        {
            this.@return = @return;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="updateMedia", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class updateMediaRequest
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute("requests", IsNullable=true)]
        public UpdateMediaRequestDto[] requests;
        
        public updateMediaRequest()
        {
        }
        
        public updateMediaRequest(UpdateMediaRequestDto[] requests)
        {
            this.requests = requests;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="updateMediaResponse", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class updateMediaResponse
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute("return", IsNullable=true)]
        public UpdateMediaResponseDto[] @return;
        
        public updateMediaResponse()
        {
        }
        
        public updateMediaResponse(UpdateMediaResponseDto[] @return)
        {
            this.@return = @return;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="fetchMediaShelvesForMedia", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class fetchMediaShelvesForMediaRequest
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute("requests", IsNullable=true)]
        public FetchMediaRequestDto[] requests;
        
        public fetchMediaShelvesForMediaRequest()
        {
        }
        
        public fetchMediaShelvesForMediaRequest(FetchMediaRequestDto[] requests)
        {
            this.requests = requests;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="fetchMediaShelvesForMediaResponse", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class fetchMediaShelvesForMediaResponse
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute("return", IsNullable=true)]
        public FetchMediaShelvesForMediaResponseDto[] @return;
        
        public fetchMediaShelvesForMediaResponse()
        {
        }
        
        public fetchMediaShelvesForMediaResponse(FetchMediaShelvesForMediaResponseDto[] @return)
        {
            this.@return = @return;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="validatePageFiles", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class validatePageFilesRequest
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute("requests", IsNullable=true)]
        public ValidatePageFileRequestDto[] requests;
        
        public validatePageFilesRequest()
        {
        }
        
        public validatePageFilesRequest(ValidatePageFileRequestDto[] requests)
        {
            this.requests = requests;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="validatePageFilesResponse", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class validatePageFilesResponse
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute("return", IsNullable=true)]
        public ValidatePageFileResponseDto[] @return;
        
        public validatePageFilesResponse()
        {
        }
        
        public validatePageFilesResponse(ValidatePageFileResponseDto[] @return)
        {
            this.@return = @return;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="updateParts", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class updatePartsRequest
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute("requests", IsNullable=true)]
        public UpdatePartRequestDto[] requests;
        
        public updatePartsRequest()
        {
        }
        
        public updatePartsRequest(UpdatePartRequestDto[] requests)
        {
            this.requests = requests;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="updatePartsResponse", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class updatePartsResponse
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute("return", IsNullable=true)]
        public UpdatePartResponseDto[] @return;
        
        public updatePartsResponse()
        {
        }
        
        public updatePartsResponse(UpdatePartResponseDto[] @return)
        {
            this.@return = @return;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="getUploadedFilesList", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class getUploadedFilesListRequest
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute(IsNullable=true)]
        public GetUploadedFilesListRequestDto request;
        
        public getUploadedFilesListRequest()
        {
        }
        
        public getUploadedFilesListRequest(GetUploadedFilesListRequestDto request)
        {
            this.request = request;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="getUploadedFilesListResponse", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class getUploadedFilesListResponse
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute(IsNullable=true)]
        public GetUploadedFilesListResponseDto @return;
        
        public getUploadedFilesListResponse()
        {
        }
        
        public getUploadedFilesListResponse(GetUploadedFilesListResponseDto @return)
        {
            this.@return = @return;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="getJobStatus", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class getJobStatusRequest
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute("requests", IsNullable=true)]
        public GetJobStatusRequestDto[] requests;
        
        public getJobStatusRequest()
        {
        }
        
        public getJobStatusRequest(GetJobStatusRequestDto[] requests)
        {
            this.requests = requests;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="getJobStatusResponse", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class getJobStatusResponse
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute("return", IsNullable=true)]
        public GetJobStatusResponseDto[] @return;
        
        public getJobStatusResponse()
        {
        }
        
        public getJobStatusResponse(GetJobStatusResponseDto[] @return)
        {
            this.@return = @return;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="partLookup", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class partLookupRequest
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute("requests", IsNullable=true)]
        public PartLookupRequestDto[] requests;
        
        public partLookupRequest()
        {
        }
        
        public partLookupRequest(PartLookupRequestDto[] requests)
        {
            this.requests = requests;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="partLookupResponse", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class partLookupResponse
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute("return", IsNullable=true)]
        public PartLookupResponseDto[] @return;
        
        public partLookupResponse()
        {
        }
        
        public partLookupResponse(PartLookupResponseDto[] @return)
        {
            this.@return = @return;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="fetchSuppliers", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class fetchSuppliersRequest
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute(IsNullable=true)]
        public FetchSuppliersRequestDto request;
        
        public fetchSuppliersRequest()
        {
        }
        
        public fetchSuppliersRequest(FetchSuppliersRequestDto request)
        {
            this.request = request;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="fetchSuppliersResponse", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class fetchSuppliersResponse
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute(IsNullable=true)]
        public FetchSuppliersResponseDto @return;
        
        public fetchSuppliersResponse()
        {
        }
        
        public fetchSuppliersResponse(FetchSuppliersResponseDto @return)
        {
            this.@return = @return;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="fetchParts", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class fetchPartsRequest
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute("requests", IsNullable=true)]
        public FetchPartRequestDto[] requests;
        
        public fetchPartsRequest()
        {
        }
        
        public fetchPartsRequest(FetchPartRequestDto[] requests)
        {
            this.requests = requests;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="fetchPartsResponse", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class fetchPartsResponse
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute("return", IsNullable=true)]
        public FetchPartResponseDto[] @return;
        
        public fetchPartsResponse()
        {
        }
        
        public fetchPartsResponse(FetchPartResponseDto[] @return)
        {
            this.@return = @return;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="publishFiles", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class publishFilesRequest
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute(IsNullable=true)]
        public PublishFilesRequestDto request;
        
        public publishFilesRequest()
        {
        }
        
        public publishFilesRequest(PublishFilesRequestDto request)
        {
            this.request = request;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="publishFilesResponse", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class publishFilesResponse
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute(IsNullable=true)]
        public PublishFilesResponseDto @return;
        
        public publishFilesResponse()
        {
        }
        
        public publishFilesResponse(PublishFilesResponseDto @return)
        {
            this.@return = @return;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="deleteTagValuesForTagNameOnMedia", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class deleteTagValuesForTagNameOnMediaRequest
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute("requests", IsNullable=true)]
        public DeleteTagValuesForTagNameOnMediaRequestDto[] requests;
        
        public deleteTagValuesForTagNameOnMediaRequest()
        {
        }
        
        public deleteTagValuesForTagNameOnMediaRequest(DeleteTagValuesForTagNameOnMediaRequestDto[] requests)
        {
            this.requests = requests;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="deleteTagValuesForTagNameOnMediaResponse", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class deleteTagValuesForTagNameOnMediaResponse
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute("return", IsNullable=true)]
        public DeleteTagValuesForTagNameOnMediaResponseDto[] @return;
        
        public deleteTagValuesForTagNameOnMediaResponse()
        {
        }
        
        public deleteTagValuesForTagNameOnMediaResponse(DeleteTagValuesForTagNameOnMediaResponseDto[] @return)
        {
            this.@return = @return;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="fetchMedia", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class fetchMediaRequest
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute("requests", IsNullable=true)]
        public FetchMediaRequestDto[] requests;
        
        public fetchMediaRequest()
        {
        }
        
        public fetchMediaRequest(FetchMediaRequestDto[] requests)
        {
            this.requests = requests;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="fetchMediaResponse", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class fetchMediaResponse
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute("return", IsNullable=true)]
        public FetchMediaResponseDto[] @return;
        
        public fetchMediaResponse()
        {
        }
        
        public fetchMediaResponse(FetchMediaResponseDto[] @return)
        {
            this.@return = @return;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="updatePagePartTags", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class updatePagePartTagsRequest
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute("requests", IsNullable=true)]
        public UpdatePagePartTagsRequestDto[] requests;
        
        public updatePagePartTagsRequest()
        {
        }
        
        public updatePagePartTagsRequest(UpdatePagePartTagsRequestDto[] requests)
        {
            this.requests = requests;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="updatePagePartTagsResponse", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class updatePagePartTagsResponse
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute("return", IsNullable=true)]
        public UpdatePagePartTagsResponseDto[] @return;
        
        public updatePagePartTagsResponse()
        {
        }
        
        public updatePagePartTagsResponse(UpdatePagePartTagsResponseDto[] @return)
        {
            this.@return = @return;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="uploadFileToBePublished", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class uploadFileToBePublishedRequest
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute("requests", IsNullable=true)]
        public UploadFileToBePublishedRequestDto[] requests;
        
        public uploadFileToBePublishedRequest()
        {
        }
        
        public uploadFileToBePublishedRequest(UploadFileToBePublishedRequestDto[] requests)
        {
            this.requests = requests;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="uploadFileToBePublishedResponse", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class uploadFileToBePublishedResponse
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute("return", IsNullable=true)]
        public UploadFileToBePublishedResponseDto[] @return;
        
        public uploadFileToBePublishedResponse()
        {
        }
        
        public uploadFileToBePublishedResponse(UploadFileToBePublishedResponseDto[] @return)
        {
            this.@return = @return;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="updateLocationData", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class updateLocationDataRequest
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute("requests", IsNullable=true)]
        public UpdateLocationDataRequestDto[] requests;
        
        public updateLocationDataRequest()
        {
        }
        
        public updateLocationDataRequest(UpdateLocationDataRequestDto[] requests)
        {
            this.requests = requests;
        }
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [MessageContractAttribute(WrapperName="updateLocationDataResponse", WrapperNamespace="http://impl.webservices.digabit.com", IsWrapped=true)]
    public partial class updateLocationDataResponse
    {
        
        [MessageBodyMemberAttribute(Namespace="http://impl.webservices.digabit.com", Order=0)]
        [XmlElementAttribute("return", IsNullable=true)]
        public UpdateLocationDataResponseDto[] @return;
        
        public updateLocationDataResponse()
        {
        }
        
        public updateLocationDataResponse(UpdateLocationDataResponseDto[] @return)
        {
            this.@return = @return;
        }
    }
    
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    public interface PublishingService20PortTypeChannel : PublishingService, IClientChannel
    {
    }
    
    [DebuggerStepThroughAttribute()]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    public partial class PublishingServiceClient : ClientBase<PublishingService>, PublishingService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(ServiceEndpoint serviceEndpoint, ClientCredentials clientCredentials);
        
        public PublishingServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
            base(PublishingServiceClient.GetBindingForEndpoint(endpointConfiguration, IsHttps(remoteAddress)), new EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        private static bool IsHttps(string address)
        {
            return address.StartsWith("https://", StringComparison.InvariantCultureIgnoreCase);
        }
        
        public PublishingServiceClient(EndpointConfiguration endpointConfiguration, EndpointAddress remoteAddress) : 
            base(PublishingServiceClient.GetBindingForEndpoint(endpointConfiguration, IsHttps(remoteAddress.Uri.AbsoluteUri)), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PublishingServiceClient(Binding binding, EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public fetchTagValuesForMediaByTagNameResponse fetchTagValuesForMediaByTagName(fetchTagValuesForMediaByTagNameRequest request)
        {
            return base.Channel.fetchTagValuesForMediaByTagName(request);
        }
        
        public Task<fetchTagValuesForMediaByTagNameResponse> fetchTagValuesForMediaByTagNameAsync(fetchTagValuesForMediaByTagNameRequest request)
        {
            return base.Channel.fetchTagValuesForMediaByTagNameAsync(request);
        }
        
        public fetchMediaIdentifiersResponse fetchMediaIdentifiers(fetchMediaIdentifiersRequest request)
        {
            return base.Channel.fetchMediaIdentifiers(request);
        }
        
        public Task<fetchMediaIdentifiersResponse> fetchMediaIdentifiersAsync(fetchMediaIdentifiersRequest request)
        {
            return base.Channel.fetchMediaIdentifiersAsync(request);
        }
        
        public supersedePartResponse supersedePart(supersedePartRequest request)
        {
            return base.Channel.supersedePart(request);
        }
        
        public Task<supersedePartResponse> supersedePartAsync(supersedePartRequest request)
        {
            return base.Channel.supersedePartAsync(request);
        }
        
        public updateMediaForBooleanResponse updateMediaForBoolean(updateMediaForBooleanRequest request)
        {
            return base.Channel.updateMediaForBoolean(request);
        }
        
        public Task<updateMediaForBooleanResponse> updateMediaForBooleanAsync(updateMediaForBooleanRequest request)
        {
            return base.Channel.updateMediaForBooleanAsync(request);
        }
        
        public setAccessControlsResponse setAccessControls(setAccessControlsRequest request)
        {
            return base.Channel.setAccessControls(request);
        }
        
        public Task<setAccessControlsResponse> setAccessControlsAsync(setAccessControlsRequest request)
        {
            return base.Channel.setAccessControlsAsync(request);
        }
        
        public fetchOrganizationAccessForMediaResponse fetchOrganizationAccessForMedia(fetchOrganizationAccessForMediaRequest request)
        {
            return base.Channel.fetchOrganizationAccessForMedia(request);
        }
        
        public Task<fetchOrganizationAccessForMediaResponse> fetchOrganizationAccessForMediaAsync(fetchOrganizationAccessForMediaRequest request)
        {
            return base.Channel.fetchOrganizationAccessForMediaAsync(request);
        }
        
        public exportMediaResponse exportMedia(exportMediaRequest request)
        {
            return base.Channel.exportMedia(request);
        }
        
        public Task<exportMediaResponse> exportMediaAsync(exportMediaRequest request)
        {
            return base.Channel.exportMediaAsync(request);
        }
        
        public fetchTagsForMediaResponse fetchTagsForMedia(fetchTagsForMediaRequest request)
        {
            return base.Channel.fetchTagsForMedia(request);
        }
        
        public Task<fetchTagsForMediaResponse> fetchTagsForMediaAsync(fetchTagsForMediaRequest request)
        {
            return base.Channel.fetchTagsForMediaAsync(request);
        }
        
        public validateBookContentResponse validateBookContent(validateBookContentRequest request)
        {
            return base.Channel.validateBookContent(request);
        }
        
        public Task<validateBookContentResponse> validateBookContentAsync(validateBookContentRequest request)
        {
            return base.Channel.validateBookContentAsync(request);
        }
        
        public updateMediaResponse updateMedia(updateMediaRequest request)
        {
            return base.Channel.updateMedia(request);
        }
        
        public Task<updateMediaResponse> updateMediaAsync(updateMediaRequest request)
        {
            return base.Channel.updateMediaAsync(request);
        }
        
        public fetchMediaShelvesForMediaResponse fetchMediaShelvesForMedia(fetchMediaShelvesForMediaRequest request)
        {
            return base.Channel.fetchMediaShelvesForMedia(request);
        }
        
        public Task<fetchMediaShelvesForMediaResponse> fetchMediaShelvesForMediaAsync(fetchMediaShelvesForMediaRequest request)
        {
            return base.Channel.fetchMediaShelvesForMediaAsync(request);
        }
        
        public validatePageFilesResponse validatePageFiles(validatePageFilesRequest request)
        {
            return base.Channel.validatePageFiles(request);
        }
        
        public Task<validatePageFilesResponse> validatePageFilesAsync(validatePageFilesRequest request)
        {
            return base.Channel.validatePageFilesAsync(request);
        }
        
        public updatePartsResponse updateParts(updatePartsRequest request)
        {
            return base.Channel.updateParts(request);
        }
        
        public Task<updatePartsResponse> updatePartsAsync(updatePartsRequest request)
        {
            return base.Channel.updatePartsAsync(request);
        }
        
        public getUploadedFilesListResponse getUploadedFilesList(getUploadedFilesListRequest request)
        {
            return base.Channel.getUploadedFilesList(request);
        }
        
        public Task<getUploadedFilesListResponse> getUploadedFilesListAsync(getUploadedFilesListRequest request)
        {
            return base.Channel.getUploadedFilesListAsync(request);
        }
        
        public getJobStatusResponse getJobStatus(getJobStatusRequest request)
        {
            return base.Channel.getJobStatus(request);
        }
        
        public Task<getJobStatusResponse> getJobStatusAsync(getJobStatusRequest request)
        {
            return base.Channel.getJobStatusAsync(request);
        }
        
        public partLookupResponse partLookup(partLookupRequest request)
        {
            return base.Channel.partLookup(request);
        }
        
        public Task<partLookupResponse> partLookupAsync(partLookupRequest request)
        {
            return base.Channel.partLookupAsync(request);
        }
        
        public fetchSuppliersResponse fetchSuppliers(fetchSuppliersRequest request)
        {
            return base.Channel.fetchSuppliers(request);
        }
        
        public Task<fetchSuppliersResponse> fetchSuppliersAsync(fetchSuppliersRequest request)
        {
            return base.Channel.fetchSuppliersAsync(request);
        }
        
        public fetchPartsResponse fetchParts(fetchPartsRequest request)
        {
            return base.Channel.fetchParts(request);
        }
        
        public Task<fetchPartsResponse> fetchPartsAsync(fetchPartsRequest request)
        {
            return base.Channel.fetchPartsAsync(request);
        }
        
        public publishFilesResponse publishFiles(publishFilesRequest request)
        {
            return base.Channel.publishFiles(request);
        }
        
        public Task<publishFilesResponse> publishFilesAsync(publishFilesRequest request)
        {
            return base.Channel.publishFilesAsync(request);
        }
        
        public deleteTagValuesForTagNameOnMediaResponse deleteTagValuesForTagNameOnMedia(deleteTagValuesForTagNameOnMediaRequest request)
        {
            return base.Channel.deleteTagValuesForTagNameOnMedia(request);
        }
        
        public Task<deleteTagValuesForTagNameOnMediaResponse> deleteTagValuesForTagNameOnMediaAsync(deleteTagValuesForTagNameOnMediaRequest request)
        {
            return base.Channel.deleteTagValuesForTagNameOnMediaAsync(request);
        }
        
        public fetchMediaResponse fetchMedia(fetchMediaRequest request)
        {
            return base.Channel.fetchMedia(request);
        }
        
        public Task<fetchMediaResponse> fetchMediaAsync(fetchMediaRequest request)
        {
            return base.Channel.fetchMediaAsync(request);
        }
        
        public updatePagePartTagsResponse updatePagePartTags(updatePagePartTagsRequest request)
        {
            return base.Channel.updatePagePartTags(request);
        }
        
        public Task<updatePagePartTagsResponse> updatePagePartTagsAsync(updatePagePartTagsRequest request)
        {
            return base.Channel.updatePagePartTagsAsync(request);
        }
        
        public uploadFileToBePublishedResponse uploadFileToBePublished(uploadFileToBePublishedRequest request)
        {
            return base.Channel.uploadFileToBePublished(request);
        }
        
        public Task<uploadFileToBePublishedResponse> uploadFileToBePublishedAsync(uploadFileToBePublishedRequest request)
        {
            return base.Channel.uploadFileToBePublishedAsync(request);
        }
        
        public updateLocationDataResponse updateLocationData(updateLocationDataRequest request)
        {
            return base.Channel.updateLocationData(request);
        }
        
        public Task<updateLocationDataResponse> updateLocationDataAsync(updateLocationDataRequest request)
        {
            return base.Channel.updateLocationDataAsync(request);
        }
        
        public virtual Task OpenAsync()
        {
            return Task.Factory.FromAsync(((ICommunicationObject)(this)).BeginOpen(null, null), new Action<IAsyncResult>(((ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual Task CloseAsync()
        {
            return Task.Factory.FromAsync(((ICommunicationObject)(this)).BeginClose(null, null), new Action<IAsyncResult>(((ICommunicationObject)(this)).EndClose));
        }
        
        private static Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration, bool isSecured)
        {
            if ((endpointConfiguration == EndpointConfiguration.PublishingService20HttpSoap11Endpoint))
            {
                BasicHttpBinding result = new BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = isSecured ? BasicHttpSecurityMode.Transport : BasicHttpSecurityMode.None;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.PublishingService20HttpSoap12Endpoint))
            {
                CustomBinding result = new CustomBinding();
                TextMessageEncodingBindingElement textBindingElement = new TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = MessageVersion.CreateVersion(EnvelopeVersion.Soap12, AddressingVersion.None);
                result.Elements.Add(textBindingElement);

                HttpTransportBindingElement httpBindingElement = isSecured ? new HttpsTransportBindingElement() : new HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            PublishingService20HttpSoap11Endpoint,
            
            PublishingService20HttpSoap12Endpoint,
        }
    }
}
