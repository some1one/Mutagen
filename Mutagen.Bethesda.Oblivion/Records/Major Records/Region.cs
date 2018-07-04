﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loqui.Internal;
using Mutagen.Bethesda.Binary;
using Mutagen.Bethesda.Oblivion.Internals;

namespace Mutagen.Bethesda.Oblivion
{
    public partial class Region
    {
        public static readonly int RDAT_LEN = 14;
        public static readonly RecordType RDOT = new RecordType("RDOT");
        public static readonly RecordType RDWT = new RecordType("RDWT");
        public static readonly RecordType RDMP = new RecordType("RDMP");
        public static readonly RecordType ICON = new RecordType("ICON");
        public static readonly RecordType RDGS = new RecordType("RDGS");
        public static readonly RecordType RDSD = new RecordType("RDSD");
        public static readonly RecordType RDMD = new RecordType("RDMD");

        static partial void FillBinary_RegionAreaLogic_Custom(MutagenFrame frame, Region item, ErrorMaskBuilder errorMask)
        {
            var rdat = HeaderTranslation.GetNextSubRecordType(frame.Reader, out var rdatType);
            while (rdat.Equals(Region_Registration.RDAT_HEADER))
            {
                ParseRegionData(frame, item, errorMask);
                rdat = HeaderTranslation.GetNextSubRecordType(frame.Reader, out rdatType);
            }
        }

        static void ParseRegionData(MutagenFrame frame, Region item, ErrorMaskBuilder errorMask)
        {
            var origPos = frame.Position;
            frame.Reader.Position += 6;
            RegionData.RegionDataType dataType = (RegionData.RegionDataType)frame.Reader.ReadUInt32();
            frame.Reader.Position += 4;
            var recType = HeaderTranslation.GetNextSubRecordType(frame.Reader, out var len);
            switch (dataType)
            {
                case RegionData.RegionDataType.Objects:
                    if (!recType.Equals(RDOT))
                    {
                        len = -6;
                    }
                    break;
                case RegionData.RegionDataType.Weather:
                    if (!recType.Equals(RDWT))
                    {
                        len = -6;
                    }
                    break;
                case RegionData.RegionDataType.MapName:
                    if (!recType.Equals(RDMP))
                    {
                        len = -6;
                    }
                    break;
                case RegionData.RegionDataType.Icon:
                    if (!recType.Equals(ICON))
                    {
                        len = -6;
                    }
                    break;
                case RegionData.RegionDataType.Grasses:
                    if (!recType.Equals(RDGS))
                    {
                        len = -6;
                    }
                    break;
                case RegionData.RegionDataType.Sounds:
                    if (!recType.Equals(RDSD) && !recType.Equals(RDMD))
                    {
                        len = -6;
                    }
                    break;
                default:
                    break;
            }
            frame.Position = origPos;
            len += RDAT_LEN + 6;
            switch (dataType)
            {
                case RegionData.RegionDataType.Objects:
                    using (var subFrame = frame.SpawnWithLength(len))
                    {
                        var obj = RegionDataObjects.Create_Binary(subFrame);
                        item.Objects = obj;
                    }
                    break;
                case RegionData.RegionDataType.MapName:
                    using (var subFrame = frame.SpawnWithLength(len))
                    {
                        var map = RegionDataMapName.Create_Binary(subFrame);
                        item.MapName = map;
                    }
                    break;
                case RegionData.RegionDataType.Grasses:
                    using (var subFrame = frame.SpawnWithLength(len))
                    {
                        var grass = RegionDataGrasses.Create_Binary(subFrame);
                        item.Grasses = grass;
                    }
                    break;
                case RegionData.RegionDataType.Sounds:
                    frame.Position += len;
                    var nextRec = HeaderTranslation.GetNextSubRecordType(frame.Reader, out var nextLen);
                    frame.Position = origPos;
                    if (nextRec.Equals(RDSD) || nextRec.Equals(RDMD))
                    {
                        len += nextLen + 6;
                    }
                    using (var subFrame = frame.SpawnWithLength(len))
                    {
                        var sounds = RegionDataSounds.Create_Binary(subFrame);
                        item.Sounds = sounds;
                    }
                    break;
                case RegionData.RegionDataType.Weather:
                    using (var subFrame = frame.SpawnWithLength(len))
                    {
                        var weather = RegionDataWeather.Create_Binary(subFrame);
                        item.Weather = weather;
                    }
                    break;
                case RegionData.RegionDataType.Icon:
                    frame.Position += 6 + RDAT_LEN;
                    len = len - 6 - RDAT_LEN;
                    if (StringBinaryTranslation.Instance.Parse(
                        frame.SpawnWithLength(len),
                        out var iconVal,
                        errorMask))
                    {
                        item.Icon = iconVal;
                    }
                    else
                    {
                        item.Icon_Property.Unset();
                    }
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        static partial void WriteBinary_RegionAreaLogic_Custom(MutagenWriter writer, Region item, ErrorMaskBuilder errorMask)
        {
            if (item.Objects_Property.HasBeenSet)
            {
                item.Objects.Write_Binary(writer);
            }
            if (item.Weather_Property.HasBeenSet)
            {
                item.Weather.Write_Binary(writer);
            }
            if (item.MapName_Property.HasBeenSet)
            {
                item.MapName.Write_Binary(writer);
            }
            if (item.Grasses_Property.HasBeenSet)
            {
                item.Grasses.Write_Binary(writer);
            }
            if (item.Sounds_Property.HasBeenSet)
            {
                item.Sounds.Write_Binary(writer);
            }
        }
    }
}
