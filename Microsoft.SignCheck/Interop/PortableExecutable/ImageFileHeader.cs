﻿using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Microsoft.SignCheck.Interop.PortableExecutable
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IMAGE_FILE_HEADER
    {
        public UInt16 Machine;
        public UInt16 NumberOfSections;
        public UInt32 TimeDateStamp;
        public UInt32 PointerToSymbolTable;
        public UInt32 NumberOfSymbols;
        public UInt16 SizeOfOptionalHeader;
        public UInt16 Characteristics;
    }

    public static class ImageFileHeader
    {
        /// <summary>
        /// Retrieves the <see cref="IMAGE_FILE_HEADER"/> using the current offset of the reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static IMAGE_FILE_HEADER Read(BinaryReader reader)
        {
            IMAGE_FILE_HEADER imageFileHeader = new IMAGE_FILE_HEADER
            {
                Machine = reader.ReadUInt16(),
                NumberOfSections = reader.ReadUInt16(),
                TimeDateStamp = reader.ReadUInt32(),
                PointerToSymbolTable = reader.ReadUInt32(),
                NumberOfSymbols = reader.ReadUInt32(),
                SizeOfOptionalHeader = reader.ReadUInt16(),
                Characteristics = reader.ReadUInt16()
            };

            return imageFileHeader;
        }
    }
}
