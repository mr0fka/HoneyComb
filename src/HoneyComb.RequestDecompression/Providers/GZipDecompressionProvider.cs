﻿using System;
using System.IO;
using System.IO.Compression;

namespace HoneyComb.RequestDecompression.Providers
{
    public class GZipDecompressionProvider : IDecompressionProvider
    {
        public string EncodingName => "gzip";

        public Stream DecompressStream(Stream compressedStream)
            => new GZipStream(compressedStream, CompressionMode.Decompress);

    }
}
