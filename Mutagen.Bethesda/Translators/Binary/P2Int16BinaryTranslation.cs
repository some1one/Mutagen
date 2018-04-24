﻿using Noggog;
using System;
using System.IO;

namespace Mutagen.Bethesda.Binary
{
    public class P2Int16BinaryTranslation : PrimitiveBinaryTranslation<P2Int16>
    {
        public readonly static P2Int16BinaryTranslation Instance = new P2Int16BinaryTranslation();
        public override ContentLength? ExpectedLength => new ContentLength(1);

        protected override P2Int16 ParseValue(MutagenFrame reader)
        {
            return new P2Int16(
                reader.Reader.ReadInt16(),
                reader.Reader.ReadInt16());
        }

        protected override void WriteValue(MutagenWriter writer, P2Int16 item)
        {
            writer.Write(item.X);
            writer.Write(item.Y);
        }
    }
}
