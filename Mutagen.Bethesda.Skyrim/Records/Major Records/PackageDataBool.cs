using System;
using System.Diagnostics;
using Mutagen.Bethesda.Plugins.Aspects;

namespace Mutagen.Bethesda.Skyrim
{
    namespace Internals
    {
        public partial class PackageDataBoolBinaryOverlay
        {
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            string INamedRequiredGetter.Name => this.Name ?? string.Empty;

            public bool Data => throw new NotImplementedException();
        }
    }
}
