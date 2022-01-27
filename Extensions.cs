using System;
using System.Text;

namespace Documoto.Publishing.Client
{
    public static class Extensions
    {
        public static byte[] BinaryToBase64Binary(this byte[] binaryData)
        {
            // convert the raw binary input into Base64 UUEncoded output.

            // each 3 byte sequence in the source data becomes a 4 byte sequence in the character array.
            var arrayLength = (long) ((4.0d / 3.0d) * binaryData.Length);

            // if array length is not divisible by 4, go up to the next multiple of 4
            if (arrayLength % 4 != 0)
                arrayLength += 4 - arrayLength % 4;

            var base64data = new char[arrayLength];
            Convert.ToBase64CharArray(binaryData, 0, binaryData.Length, base64data, 0);

            return Encoding.UTF8.GetBytes(base64data);
        }

    }
}
