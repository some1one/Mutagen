/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
#region Usings
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Loqui;
using Loqui.Internal;
using Noggog;
using Mutagen.Bethesda.Oblivion.Internals;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Mutagen.Bethesda.Binary;
using System.Buffers.Binary;
using Mutagen.Bethesda.Internals;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Oblivion
{
    #region Class
    public partial class SoulGemData :
        ISoulGemData,
        ILoquiObjectSetter<SoulGemData>,
        IEquatable<ISoulGemDataGetter>
    {
        #region Ctor
        public SoulGemData()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region Value
        public UInt32 Value { get; set; } = default;
        #endregion
        #region Weight
        public Single Weight { get; set; } = default;
        #endregion

        #region To String

        public void ToString(
            FileGeneration fg,
            string? name = null)
        {
            SoulGemDataMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (!(obj is ISoulGemDataGetter rhs)) return false;
            return ((SoulGemDataCommon)((ISoulGemDataGetter)this).CommonInstance()!).Equals(this, rhs);
        }

        public bool Equals(ISoulGemDataGetter? obj)
        {
            return ((SoulGemDataCommon)((ISoulGemDataGetter)this).CommonInstance()!).Equals(this, obj);
        }

        public override int GetHashCode() => ((SoulGemDataCommon)((ISoulGemDataGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public class Mask<TItem> :
            IMask<TItem>,
            IEquatable<Mask<TItem>>
        {
            #region Ctors
            public Mask(TItem initialValue)
            {
                this.Value = initialValue;
                this.Weight = initialValue;
            }

            public Mask(
                TItem Value,
                TItem Weight)
            {
                this.Value = Value;
                this.Weight = Weight;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem Value;
            public TItem Weight;
            #endregion

            #region Equals
            public override bool Equals(object? obj)
            {
                if (!(obj is Mask<TItem> rhs)) return false;
                return Equals(rhs);
            }

            public bool Equals(Mask<TItem>? rhs)
            {
                if (rhs == null) return false;
                if (!object.Equals(this.Value, rhs.Value)) return false;
                if (!object.Equals(this.Weight, rhs.Weight)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.Value);
                hash.Add(this.Weight);
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public bool All(Func<TItem, bool> eval)
            {
                if (!eval(this.Value)) return false;
                if (!eval(this.Weight)) return false;
                return true;
            }
            #endregion

            #region Any
            public bool Any(Func<TItem, bool> eval)
            {
                if (eval(this.Value)) return true;
                if (eval(this.Weight)) return true;
                return false;
            }
            #endregion

            #region Translate
            public Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new SoulGemData.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                obj.Value = eval(this.Value);
                obj.Weight = eval(this.Weight);
            }
            #endregion

            #region To String
            public override string ToString()
            {
                return ToString(printMask: null);
            }

            public string ToString(SoulGemData.Mask<bool>? printMask = null)
            {
                var fg = new FileGeneration();
                ToString(fg, printMask);
                return fg.ToString();
            }

            public void ToString(FileGeneration fg, SoulGemData.Mask<bool>? printMask = null)
            {
                fg.AppendLine($"{nameof(SoulGemData.Mask<TItem>)} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
                    if (printMask?.Value ?? true)
                    {
                        fg.AppendItem(Value, "Value");
                    }
                    if (printMask?.Weight ?? true)
                    {
                        fg.AppendItem(Weight, "Weight");
                    }
                }
                fg.AppendLine("]");
            }
            #endregion

        }

        public class ErrorMask :
            IErrorMask,
            IErrorMask<ErrorMask>
        {
            #region Members
            public Exception? Overall { get; set; }
            private List<string>? _warnings;
            public List<string> Warnings
            {
                get
                {
                    if (_warnings == null)
                    {
                        _warnings = new List<string>();
                    }
                    return _warnings;
                }
            }
            public Exception? Value;
            public Exception? Weight;
            #endregion

            #region IErrorMask
            public object? GetNthMask(int index)
            {
                SoulGemData_FieldIndex enu = (SoulGemData_FieldIndex)index;
                switch (enu)
                {
                    case SoulGemData_FieldIndex.Value:
                        return Value;
                    case SoulGemData_FieldIndex.Weight:
                        return Weight;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthException(int index, Exception ex)
            {
                SoulGemData_FieldIndex enu = (SoulGemData_FieldIndex)index;
                switch (enu)
                {
                    case SoulGemData_FieldIndex.Value:
                        this.Value = ex;
                        break;
                    case SoulGemData_FieldIndex.Weight:
                        this.Weight = ex;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthMask(int index, object obj)
            {
                SoulGemData_FieldIndex enu = (SoulGemData_FieldIndex)index;
                switch (enu)
                {
                    case SoulGemData_FieldIndex.Value:
                        this.Value = (Exception?)obj;
                        break;
                    case SoulGemData_FieldIndex.Weight:
                        this.Weight = (Exception?)obj;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public bool IsInError()
            {
                if (Overall != null) return true;
                if (Value != null) return true;
                if (Weight != null) return true;
                return false;
            }
            #endregion

            #region To String
            public override string ToString()
            {
                var fg = new FileGeneration();
                ToString(fg, null);
                return fg.ToString();
            }

            public void ToString(FileGeneration fg, string? name = null)
            {
                fg.AppendLine($"{(name ?? "ErrorMask")} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
                    if (this.Overall != null)
                    {
                        fg.AppendLine("Overall =>");
                        fg.AppendLine("[");
                        using (new DepthWrapper(fg))
                        {
                            fg.AppendLine($"{this.Overall}");
                        }
                        fg.AppendLine("]");
                    }
                    ToString_FillInternal(fg);
                }
                fg.AppendLine("]");
            }
            protected void ToString_FillInternal(FileGeneration fg)
            {
                fg.AppendItem(Value, "Value");
                fg.AppendItem(Weight, "Weight");
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.Value = this.Value.Combine(rhs.Value);
                ret.Weight = this.Weight.Combine(rhs.Weight);
                return ret;
            }
            public static ErrorMask? Combine(ErrorMask? lhs, ErrorMask? rhs)
            {
                if (lhs != null && rhs != null) return lhs.Combine(rhs);
                return lhs ?? rhs;
            }
            #endregion

            #region Factory
            public static ErrorMask Factory(ErrorMaskBuilder errorMask)
            {
                return new ErrorMask();
            }
            #endregion

        }
        public class TranslationMask : ITranslationMask
        {
            #region Members
            private TranslationCrystal? _crystal;
            public readonly bool DefaultOn;
            public bool Value;
            public bool Weight;
            #endregion

            #region Ctors
            public TranslationMask(bool defaultOn)
            {
                this.DefaultOn = defaultOn;
                this.Value = defaultOn;
                this.Weight = defaultOn;
            }

            #endregion

            public TranslationCrystal GetCrystal()
            {
                if (_crystal != null) return _crystal;
                var ret = new List<(bool On, TranslationCrystal? SubCrystal)>();
                GetCrystal(ret);
                _crystal = new TranslationCrystal(ret.ToArray());
                return _crystal;
            }

            protected void GetCrystal(List<(bool On, TranslationCrystal? SubCrystal)> ret)
            {
                ret.Add((Value, null));
                ret.Add((Weight, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn);
            }

        }
        #endregion

        #region Mutagen
        public static readonly RecordType GrupRecordType = SoulGemData_Registration.TriggeringRecordType;
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected object BinaryWriteTranslator => SoulGemDataBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((SoulGemDataBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }
        #region Binary Create
        public static SoulGemData CreateFromBinary(
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var ret = new SoulGemData();
            ((SoulGemDataSetterCommon)((ISoulGemDataGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                recordTypeConverter: recordTypeConverter);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out SoulGemData item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var startPos = frame.Position;
            item = CreateFromBinary(frame, recordTypeConverter);
            return startPos != frame.Position;
        }
        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        void IClearable.Clear()
        {
            ((SoulGemDataSetterCommon)((ISoulGemDataGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static SoulGemData GetNew()
        {
            return new SoulGemData();
        }

    }
    #endregion

    #region Interface
    public partial interface ISoulGemData :
        ISoulGemDataGetter,
        ILoquiObjectSetter<ISoulGemData>
    {
        new UInt32 Value { get; set; }
        new Single Weight { get; set; }
    }

    public partial interface ISoulGemDataGetter :
        ILoquiObject,
        ILoquiObject<ISoulGemDataGetter>,
        IBinaryItem
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object? CommonSetterInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonSetterTranslationInstance();
        static ILoquiRegistration Registration => SoulGemData_Registration.Instance;
        UInt32 Value { get; }
        Single Weight { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class SoulGemDataMixIn
    {
        public static void Clear(this ISoulGemData item)
        {
            ((SoulGemDataSetterCommon)((ISoulGemDataGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static SoulGemData.Mask<bool> GetEqualsMask(
            this ISoulGemDataGetter item,
            ISoulGemDataGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((SoulGemDataCommon)((ISoulGemDataGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string ToString(
            this ISoulGemDataGetter item,
            string? name = null,
            SoulGemData.Mask<bool>? printMask = null)
        {
            return ((SoulGemDataCommon)((ISoulGemDataGetter)item).CommonInstance()!).ToString(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void ToString(
            this ISoulGemDataGetter item,
            FileGeneration fg,
            string? name = null,
            SoulGemData.Mask<bool>? printMask = null)
        {
            ((SoulGemDataCommon)((ISoulGemDataGetter)item).CommonInstance()!).ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this ISoulGemDataGetter item,
            ISoulGemDataGetter rhs)
        {
            return ((SoulGemDataCommon)((ISoulGemDataGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs);
        }

        public static void DeepCopyIn(
            this ISoulGemData lhs,
            ISoulGemDataGetter rhs)
        {
            ((SoulGemDataSetterTranslationCommon)((ISoulGemDataGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: default,
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this ISoulGemData lhs,
            ISoulGemDataGetter rhs,
            SoulGemData.TranslationMask? copyMask = null)
        {
            ((SoulGemDataSetterTranslationCommon)((ISoulGemDataGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this ISoulGemData lhs,
            ISoulGemDataGetter rhs,
            out SoulGemData.ErrorMask errorMask,
            SoulGemData.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((SoulGemDataSetterTranslationCommon)((ISoulGemDataGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = SoulGemData.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this ISoulGemData lhs,
            ISoulGemDataGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((SoulGemDataSetterTranslationCommon)((ISoulGemDataGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static SoulGemData DeepCopy(
            this ISoulGemDataGetter item,
            SoulGemData.TranslationMask? copyMask = null)
        {
            return ((SoulGemDataSetterTranslationCommon)((ISoulGemDataGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static SoulGemData DeepCopy(
            this ISoulGemDataGetter item,
            out SoulGemData.ErrorMask errorMask,
            SoulGemData.TranslationMask? copyMask = null)
        {
            return ((SoulGemDataSetterTranslationCommon)((ISoulGemDataGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static SoulGemData DeepCopy(
            this ISoulGemDataGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((SoulGemDataSetterTranslationCommon)((ISoulGemDataGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this ISoulGemData item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((SoulGemDataSetterCommon)((ISoulGemDataGetter)item).CommonSetterInstance()!).CopyInFromBinary(
                item: item,
                frame: frame,
                recordTypeConverter: recordTypeConverter);
        }

        #endregion

    }
    #endregion

}

namespace Mutagen.Bethesda.Oblivion.Internals
{
    #region Field Index
    public enum SoulGemData_FieldIndex
    {
        Value = 0,
        Weight = 1,
    }
    #endregion

    #region Registration
    public partial class SoulGemData_Registration : ILoquiRegistration
    {
        public static readonly SoulGemData_Registration Instance = new SoulGemData_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Oblivion.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Oblivion.ProtocolKey,
            msgID: 210,
            version: 0);

        public const string GUID = "fbd6e35a-823a-449e-9f19-64a248547970";

        public const ushort AdditionalFieldCount = 2;

        public const ushort FieldCount = 2;

        public static readonly Type MaskType = typeof(SoulGemData.Mask<>);

        public static readonly Type ErrorMaskType = typeof(SoulGemData.ErrorMask);

        public static readonly Type ClassType = typeof(SoulGemData);

        public static readonly Type GetterType = typeof(ISoulGemDataGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(ISoulGemData);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Oblivion.SoulGemData";

        public const string Name = "SoulGemData";

        public const string Namespace = "Mutagen.Bethesda.Oblivion";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly RecordType TriggeringRecordType = RecordTypes.DATA;
        public static readonly Type BinaryWriteTranslation = typeof(SoulGemDataBinaryWriteTranslation);
        #region Interface
        ProtocolKey ILoquiRegistration.ProtocolKey => ProtocolKey;
        ObjectKey ILoquiRegistration.ObjectKey => ObjectKey;
        string ILoquiRegistration.GUID => GUID;
        ushort ILoquiRegistration.FieldCount => FieldCount;
        ushort ILoquiRegistration.AdditionalFieldCount => AdditionalFieldCount;
        Type ILoquiRegistration.MaskType => MaskType;
        Type ILoquiRegistration.ErrorMaskType => ErrorMaskType;
        Type ILoquiRegistration.ClassType => ClassType;
        Type ILoquiRegistration.SetterType => SetterType;
        Type? ILoquiRegistration.InternalSetterType => InternalSetterType;
        Type ILoquiRegistration.GetterType => GetterType;
        Type? ILoquiRegistration.InternalGetterType => InternalGetterType;
        string ILoquiRegistration.FullName => FullName;
        string ILoquiRegistration.Name => Name;
        string ILoquiRegistration.Namespace => Namespace;
        byte ILoquiRegistration.GenericCount => GenericCount;
        Type? ILoquiRegistration.GenericRegistrationType => GenericRegistrationType;
        ushort? ILoquiRegistration.GetNameIndex(StringCaseAgnostic name) => throw new NotImplementedException();
        bool ILoquiRegistration.GetNthIsEnumerable(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.GetNthIsLoqui(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.GetNthIsSingleton(ushort index) => throw new NotImplementedException();
        string ILoquiRegistration.GetNthName(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.IsNthDerivative(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.IsProtected(ushort index) => throw new NotImplementedException();
        Type ILoquiRegistration.GetNthType(ushort index) => throw new NotImplementedException();
        #endregion

    }
    #endregion

    #region Common
    public partial class SoulGemDataSetterCommon
    {
        public static readonly SoulGemDataSetterCommon Instance = new SoulGemDataSetterCommon();

        partial void ClearPartial();
        
        public void Clear(ISoulGemData item)
        {
            ClearPartial();
            item.Value = default;
            item.Weight = default;
        }
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            ISoulGemData item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            frame = frame.SpawnWithFinalPosition(HeaderTranslation.ParseSubrecord(
                frame.Reader,
                recordTypeConverter.ConvertToCustom(RecordTypes.DATA)));
            UtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                recordTypeConverter: recordTypeConverter,
                fillStructs: SoulGemDataBinaryCreateTranslation.FillBinaryStructs);
        }
        
        #endregion
        
    }
    public partial class SoulGemDataCommon
    {
        public static readonly SoulGemDataCommon Instance = new SoulGemDataCommon();

        public SoulGemData.Mask<bool> GetEqualsMask(
            ISoulGemDataGetter item,
            ISoulGemDataGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new SoulGemData.Mask<bool>(false);
            ((SoulGemDataCommon)((ISoulGemDataGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            ISoulGemDataGetter item,
            ISoulGemDataGetter rhs,
            SoulGemData.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
            ret.Value = item.Value == rhs.Value;
            ret.Weight = item.Weight.EqualsWithin(rhs.Weight);
        }
        
        public string ToString(
            ISoulGemDataGetter item,
            string? name = null,
            SoulGemData.Mask<bool>? printMask = null)
        {
            var fg = new FileGeneration();
            ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
            return fg.ToString();
        }
        
        public void ToString(
            ISoulGemDataGetter item,
            FileGeneration fg,
            string? name = null,
            SoulGemData.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                fg.AppendLine($"SoulGemData =>");
            }
            else
            {
                fg.AppendLine($"{name} (SoulGemData) =>");
            }
            fg.AppendLine("[");
            using (new DepthWrapper(fg))
            {
                ToStringFields(
                    item: item,
                    fg: fg,
                    printMask: printMask);
            }
            fg.AppendLine("]");
        }
        
        protected static void ToStringFields(
            ISoulGemDataGetter item,
            FileGeneration fg,
            SoulGemData.Mask<bool>? printMask = null)
        {
            if (printMask?.Value ?? true)
            {
                fg.AppendItem(item.Value, "Value");
            }
            if (printMask?.Weight ?? true)
            {
                fg.AppendItem(item.Weight, "Weight");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            ISoulGemDataGetter? lhs,
            ISoulGemDataGetter? rhs)
        {
            if (lhs == null && rhs == null) return false;
            if (lhs == null || rhs == null) return false;
            if (lhs.Value != rhs.Value) return false;
            if (!lhs.Weight.EqualsWithin(rhs.Weight)) return false;
            return true;
        }
        
        public virtual int GetHashCode(ISoulGemDataGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.Value);
            hash.Add(item.Weight);
            return hash.ToHashCode();
        }
        
        #endregion
        
        
        public object GetNew()
        {
            return SoulGemData.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<FormKey> GetLinkFormKeys(ISoulGemDataGetter obj)
        {
            yield break;
        }
        
        public void RemapLinks(ISoulGemDataGetter obj, IReadOnlyDictionary<FormKey, FormKey> mapping) => throw new NotImplementedException();
        #endregion
        
    }
    public partial class SoulGemDataSetterTranslationCommon
    {
        public static readonly SoulGemDataSetterTranslationCommon Instance = new SoulGemDataSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            ISoulGemData item,
            ISoulGemDataGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            if ((copyMask?.GetShouldTranslate((int)SoulGemData_FieldIndex.Value) ?? true))
            {
                item.Value = rhs.Value;
            }
            if ((copyMask?.GetShouldTranslate((int)SoulGemData_FieldIndex.Weight) ?? true))
            {
                item.Weight = rhs.Weight;
            }
        }
        
        #endregion
        
        public SoulGemData DeepCopy(
            ISoulGemDataGetter item,
            SoulGemData.TranslationMask? copyMask = null)
        {
            SoulGemData ret = (SoulGemData)((SoulGemDataCommon)((ISoulGemDataGetter)item).CommonInstance()!).GetNew();
            ((SoulGemDataSetterTranslationCommon)((ISoulGemDataGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public SoulGemData DeepCopy(
            ISoulGemDataGetter item,
            out SoulGemData.ErrorMask errorMask,
            SoulGemData.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            SoulGemData ret = (SoulGemData)((SoulGemDataCommon)((ISoulGemDataGetter)item).CommonInstance()!).GetNew();
            ((SoulGemDataSetterTranslationCommon)((ISoulGemDataGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = SoulGemData.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public SoulGemData DeepCopy(
            ISoulGemDataGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            SoulGemData ret = (SoulGemData)((SoulGemDataCommon)((ISoulGemDataGetter)item).CommonInstance()!).GetNew();
            ((SoulGemDataSetterTranslationCommon)((ISoulGemDataGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: true);
            return ret;
        }
        
    }
    #endregion

}

namespace Mutagen.Bethesda.Oblivion
{
    public partial class SoulGemData
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => SoulGemData_Registration.Instance;
        public static SoulGemData_Registration Registration => SoulGemData_Registration.Instance;
        [DebuggerStepThrough]
        protected object CommonInstance() => SoulGemDataCommon.Instance;
        [DebuggerStepThrough]
        protected object CommonSetterInstance()
        {
            return SoulGemDataSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected object CommonSetterTranslationInstance() => SoulGemDataSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object ISoulGemDataGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object ISoulGemDataGetter.CommonSetterInstance() => this.CommonSetterInstance();
        [DebuggerStepThrough]
        object ISoulGemDataGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Oblivion.Internals
{
    public partial class SoulGemDataBinaryWriteTranslation : IBinaryWriteTranslator
    {
        public readonly static SoulGemDataBinaryWriteTranslation Instance = new SoulGemDataBinaryWriteTranslation();

        public static void WriteEmbedded(
            ISoulGemDataGetter item,
            MutagenWriter writer)
        {
            writer.Write(item.Value);
            Mutagen.Bethesda.Binary.FloatBinaryTranslation.Instance.Write(
                writer: writer,
                item: item.Weight);
        }

        public void Write(
            MutagenWriter writer,
            ISoulGemDataGetter item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            using (HeaderExport.Header(
                writer: writer,
                record: recordTypeConverter.ConvertToCustom(RecordTypes.DATA),
                type: Mutagen.Bethesda.Binary.ObjectType.Subrecord))
            {
                WriteEmbedded(
                    item: item,
                    writer: writer);
            }
        }

        public void Write(
            MutagenWriter writer,
            object item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            Write(
                item: (ISoulGemDataGetter)item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

    }

    public partial class SoulGemDataBinaryCreateTranslation
    {
        public readonly static SoulGemDataBinaryCreateTranslation Instance = new SoulGemDataBinaryCreateTranslation();

        public static void FillBinaryStructs(
            ISoulGemData item,
            MutagenFrame frame)
        {
            item.Value = frame.ReadUInt32();
            item.Weight = Mutagen.Bethesda.Binary.FloatBinaryTranslation.Instance.Parse(frame: frame);
        }

    }

}
namespace Mutagen.Bethesda.Oblivion
{
    #region Binary Write Mixins
    public static class SoulGemDataBinaryTranslationMixIn
    {
        public static void WriteToBinary(
            this ISoulGemDataGetter item,
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((SoulGemDataBinaryWriteTranslation)item.BinaryWriteTranslator).Write(
                item: item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

    }
    #endregion


}
namespace Mutagen.Bethesda.Oblivion.Internals
{
    public partial class SoulGemDataBinaryOverlay :
        BinaryOverlay,
        ISoulGemDataGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => SoulGemData_Registration.Instance;
        public static SoulGemData_Registration Registration => SoulGemData_Registration.Instance;
        [DebuggerStepThrough]
        protected object CommonInstance() => SoulGemDataCommon.Instance;
        [DebuggerStepThrough]
        protected object CommonSetterTranslationInstance() => SoulGemDataSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object ISoulGemDataGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object? ISoulGemDataGetter.CommonSetterInstance() => null;
        [DebuggerStepThrough]
        object ISoulGemDataGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected object BinaryWriteTranslator => SoulGemDataBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((SoulGemDataBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

        public UInt32 Value => BinaryPrimitives.ReadUInt32LittleEndian(_data.Slice(0x0, 0x4));
        public Single Weight => _data.Slice(0x4, 0x4).Float();
        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected SoulGemDataBinaryOverlay(
            ReadOnlyMemorySlice<byte> bytes,
            BinaryOverlayFactoryPackage package)
            : base(
                bytes: bytes,
                package: package)
        {
            this.CustomCtor();
        }

        public static SoulGemDataBinaryOverlay SoulGemDataFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var ret = new SoulGemDataBinaryOverlay(
                bytes: HeaderTranslation.ExtractSubrecordMemory(stream.RemainingMemory, package.MetaData.Constants),
                package: package);
            var finalPos = checked((int)(stream.Position + stream.GetSubrecord().TotalLength));
            int offset = stream.Position + package.MetaData.Constants.SubConstants.TypeAndLengthLength;
            stream.Position += 0x8 + package.MetaData.Constants.SubConstants.HeaderLength;
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static SoulGemDataBinaryOverlay SoulGemDataFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            RecordTypeConverter? recordTypeConverter = null)
        {
            return SoulGemDataFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                recordTypeConverter: recordTypeConverter);
        }

        #region To String

        public void ToString(
            FileGeneration fg,
            string? name = null)
        {
            SoulGemDataMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (!(obj is ISoulGemDataGetter rhs)) return false;
            return ((SoulGemDataCommon)((ISoulGemDataGetter)this).CommonInstance()!).Equals(this, rhs);
        }

        public bool Equals(ISoulGemDataGetter? obj)
        {
            return ((SoulGemDataCommon)((ISoulGemDataGetter)this).CommonInstance()!).Equals(this, obj);
        }

        public override int GetHashCode() => ((SoulGemDataCommon)((ISoulGemDataGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

