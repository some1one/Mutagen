using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loqui.Internal;
using Mutagen.Bethesda.Binary;
using Mutagen.Bethesda.Oblivion.Internals;

namespace Mutagen.Bethesda.Oblivion
{
    public partial class PlacedObject
    {
        [Flags]
        public enum ActionFlag
        {
            UseDefault = 0x001,
            Activate = 0x002,
            Open = 0x004,
            OpenByDefault = 0x008
        }
    }

    namespace Internals
    {
        public partial class PlacedObjectBinaryCreateTranslation
        {
            static partial void FillBinaryOpenByDefaultCustom(MutagenFrame frame, PlacedObject item, MasterReferences masterReferences, ErrorMaskBuilder errorMask)
            {
                item.OpenByDefault = true;
                frame.Position += frame.MetaData.SubConstants.HeaderLength;
            }
        }

        public partial class PlacedObjectBinaryWriteTranslation
        {
            static partial void WriteBinaryOpenByDefaultCustom(MutagenWriter writer, IPlacedObjectInternalGetter item, MasterReferences masterReferences, ErrorMaskBuilder errorMask)
            {
                if (item.OpenByDefault)
                {
                    using (HeaderExport.ExportSubRecordHeader(writer, PlacedObject_Registration.ONAM_HEADER))
                    {
                    }
                }
            }
        }

        public partial class PlacedObjectBinaryWrapper
        {
            public bool GetOpenByDefaultCustom(
                ReadOnlySpan<byte> span,
                int location,
                int? expectedLength,
                BinaryWrapperFactoryPackage package)
            {
                return true;
            }
        }
    }
}
