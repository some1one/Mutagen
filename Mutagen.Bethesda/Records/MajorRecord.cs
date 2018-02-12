﻿using Loqui;
using Mutagen.Bethesda.Binary;
using Mutagen.Bethesda.Internals;
using Noggog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutagen.Bethesda
{
    [DebuggerDisplay("{GetType().Name} {this.EditorID?.ToString()} {this.FormID.ToString()}")]
    public partial class MajorRecord
    {
        [Flags]
        public enum MajorRecordFlag
        {
            ESM = 0x00000001,
            Deleted = 0x00000020,
            BorderRegion_ActorValue = 0x00000040,
            TurnOffFire_ActorValue = 0x00000080,
            CastsShadows = 0x00000200,
            QuestItemPersistentReference = 0x00000400,
            InitiallyDisabled = 0x00000800,
            Ignored = 0x00001000,
            VisibleWhenDistant = 0x00008000,
            Dangerous_OffLimits_InteriorCell = 0x00020000,
            Compressed = 0x00040000,
            CantWait = 0x00080000,
        }

        public string TitleString => $"{this.EditorID} - {this.FormID.IDString()}";
        
        public static void Fill_Binary(
            MutagenFrame frame,
            MajorRecord record,
            bool doMasks,
            out MajorRecord_ErrorMask errorMask)
        {
            MajorRecord_ErrorMask errMask = null;
            Func<MajorRecord_ErrorMask> errorMaskCreator = () =>
            {
                if (errMask == null)
                {
                    errMask = new MajorRecord_ErrorMask();
                }
                return errMask;
            };
            Fill_Binary_Structs(
                record,
                frame,
                errorMaskCreator);
            for (int i = 0; i < MajorRecord_Registration.NumTypedFields; i++)
            {
                Fill_Binary_RecordTypes(
                    record,
                    frame,
                    errorMaskCreator);
            }
            errorMask = errMask;
        }
    }
}
