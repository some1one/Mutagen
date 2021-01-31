using Mutagen.Bethesda.Binary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Mutagen.Bethesda.Skyrim
{
    public partial class Armor
    {
        #region Interfaces
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IObjectBoundsGetter IObjectBoundedGetter.ObjectBounds => this.ObjectBounds;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ObjectBounds? IObjectBoundedOptional.ObjectBounds
        {
            get => this.ObjectBounds;
            set => this.ObjectBounds = value ?? new ObjectBounds();
        }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IObjectBoundsGetter? IObjectBoundedOptionalGetter.ObjectBounds => this.ObjectBounds;
        #endregion

        [Flags]
        public enum MajorFlag
        {
            NonPlayable = 0x0000_0004,
            Shield = 0x0000_0040
        }
    }

    namespace Internals
    {
        public partial class ArmorBinaryCreateTranslation
        {
            static partial void FillBinaryBodyTemplateCustom(MutagenFrame frame, IArmorInternal item)
            {
                item.BodyTemplate = BodyTemplateBinaryCreateTranslation.Parse(frame);
            }
        }

        public partial class ArmorBinaryWriteTranslation
        {
            static partial void WriteBinaryBodyTemplateCustom(MutagenWriter writer, IArmorGetter item)
            {
                if (item.BodyTemplate.TryGet(out var templ))
                {
                    BodyTemplateBinaryWriteTranslation.Write(writer, templ);
                }
            }
        }

        public partial class ArmorBinaryOverlay
        {
            private int? _BodyTemplateLocation;
            public IBodyTemplateGetter? GetBodyTemplateCustom() => _BodyTemplateLocation.HasValue ? BodyTemplateBinaryOverlay.CustomFactory(new OverlayStream(_data.Slice(_BodyTemplateLocation!.Value), _package), _package) : default;
            public bool BodyTemplate_IsSet => _BodyTemplateLocation.HasValue;

            partial void BodyTemplateCustomParse(OverlayStream stream, long finalPos, int offset)
            {
                _BodyTemplateLocation = (stream.Position - offset);
            }
        }
    }
}
