/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
#region Usings
using Loqui;
using Loqui.Interfaces;
using Loqui.Internal;
using Mutagen.Bethesda.Binary;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Binary.Headers;
using Mutagen.Bethesda.Plugins.Binary.Overlay;
using Mutagen.Bethesda.Plugins.Binary.Streams;
using Mutagen.Bethesda.Plugins.Binary.Translations;
using Mutagen.Bethesda.Plugins.Exceptions;
using Mutagen.Bethesda.Plugins.Internals;
using Mutagen.Bethesda.Plugins.Records;
using Mutagen.Bethesda.Plugins.Records.Internals;
using Mutagen.Bethesda.Plugins.Records.Mapping;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Skyrim.Internals;
using Mutagen.Bethesda.Translations.Binary;
using Noggog;
using Noggog.StructuredStrings;
using Noggog.StructuredStrings.CSharp;
using RecordTypeInts = Mutagen.Bethesda.Skyrim.Internals.RecordTypeInts;
using RecordTypes = Mutagen.Bethesda.Skyrim.Internals.RecordTypes;
using System.Buffers.Binary;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reactive.Disposables;
using System.Reactive.Linq;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Skyrim
{
    #region Class
    public partial class PcLevelMult :
        ANpcLevel,
        IEquatable<IPcLevelMultGetter>,
        ILoquiObjectSetter<PcLevelMult>,
        IPcLevelMult
    {
        #region Ctor
        public PcLevelMult()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region LevelMult
        public Single LevelMult { get; set; } = default;
        #endregion

        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            PcLevelMultMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IPcLevelMultGetter rhs) return false;
            return ((PcLevelMultCommon)((IPcLevelMultGetter)this).CommonInstance()!).Equals(this, rhs, equalsMask: null);
        }

        public bool Equals(IPcLevelMultGetter? obj)
        {
            return ((PcLevelMultCommon)((IPcLevelMultGetter)this).CommonInstance()!).Equals(this, obj, equalsMask: null);
        }

        public override int GetHashCode() => ((PcLevelMultCommon)((IPcLevelMultGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public new class Mask<TItem> :
            ANpcLevel.Mask<TItem>,
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem LevelMult)
            : base()
            {
                this.LevelMult = LevelMult;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem LevelMult;
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
                if (!base.Equals(rhs)) return false;
                if (!object.Equals(this.LevelMult, rhs.LevelMult)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.LevelMult);
                hash.Add(base.GetHashCode());
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public override bool All(Func<TItem, bool> eval)
            {
                if (!base.All(eval)) return false;
                if (!eval(this.LevelMult)) return false;
                return true;
            }
            #endregion

            #region Any
            public override bool Any(Func<TItem, bool> eval)
            {
                if (base.Any(eval)) return true;
                if (eval(this.LevelMult)) return true;
                return false;
            }
            #endregion

            #region Translate
            public new Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new PcLevelMult.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                base.Translate_InternalFill(obj, eval);
                obj.LevelMult = eval(this.LevelMult);
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public string Print(PcLevelMult.Mask<bool>? printMask = null)
            {
                var sb = new StructuredStringBuilder();
                Print(sb, printMask);
                return sb.ToString();
            }

            public void Print(StructuredStringBuilder sb, PcLevelMult.Mask<bool>? printMask = null)
            {
                sb.AppendLine($"{nameof(PcLevelMult.Mask<TItem>)} =>");
                using (sb.Brace())
                {
                    if (printMask?.LevelMult ?? true)
                    {
                        sb.AppendItem(LevelMult, "LevelMult");
                    }
                }
            }
            #endregion

        }

        public new class ErrorMask :
            ANpcLevel.ErrorMask,
            IErrorMask<ErrorMask>
        {
            #region Members
            public Exception? LevelMult;
            #endregion

            #region IErrorMask
            public override object? GetNthMask(int index)
            {
                PcLevelMult_FieldIndex enu = (PcLevelMult_FieldIndex)index;
                switch (enu)
                {
                    case PcLevelMult_FieldIndex.LevelMult:
                        return LevelMult;
                    default:
                        return base.GetNthMask(index);
                }
            }

            public override void SetNthException(int index, Exception ex)
            {
                PcLevelMult_FieldIndex enu = (PcLevelMult_FieldIndex)index;
                switch (enu)
                {
                    case PcLevelMult_FieldIndex.LevelMult:
                        this.LevelMult = ex;
                        break;
                    default:
                        base.SetNthException(index, ex);
                        break;
                }
            }

            public override void SetNthMask(int index, object obj)
            {
                PcLevelMult_FieldIndex enu = (PcLevelMult_FieldIndex)index;
                switch (enu)
                {
                    case PcLevelMult_FieldIndex.LevelMult:
                        this.LevelMult = (Exception?)obj;
                        break;
                    default:
                        base.SetNthMask(index, obj);
                        break;
                }
            }

            public override bool IsInError()
            {
                if (Overall != null) return true;
                if (LevelMult != null) return true;
                return false;
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public override void Print(StructuredStringBuilder sb, string? name = null)
            {
                sb.AppendLine($"{(name ?? "ErrorMask")} =>");
                using (sb.Brace())
                {
                    if (this.Overall != null)
                    {
                        sb.AppendLine("Overall =>");
                        using (sb.Brace())
                        {
                            sb.AppendLine($"{this.Overall}");
                        }
                    }
                    PrintFillInternal(sb);
                }
            }
            protected override void PrintFillInternal(StructuredStringBuilder sb)
            {
                base.PrintFillInternal(sb);
                {
                    sb.AppendItem(LevelMult, "LevelMult");
                }
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.LevelMult = this.LevelMult.Combine(rhs.LevelMult);
                return ret;
            }
            public static ErrorMask? Combine(ErrorMask? lhs, ErrorMask? rhs)
            {
                if (lhs != null && rhs != null) return lhs.Combine(rhs);
                return lhs ?? rhs;
            }
            #endregion

            #region Factory
            public static new ErrorMask Factory(ErrorMaskBuilder errorMask)
            {
                return new ErrorMask();
            }
            #endregion

        }
        public new class TranslationMask :
            ANpcLevel.TranslationMask,
            ITranslationMask
        {
            #region Members
            public bool LevelMult;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
                : base(defaultOn, onOverall)
            {
                this.LevelMult = defaultOn;
            }

            #endregion

            protected override void GetCrystal(List<(bool On, TranslationCrystal? SubCrystal)> ret)
            {
                base.GetCrystal(ret);
                ret.Add((LevelMult, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => PcLevelMultBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((PcLevelMultBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }
        #region Binary Create
        public new static PcLevelMult CreateFromBinary(
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            var ret = new PcLevelMult();
            ((PcLevelMultSetterCommon)((IPcLevelMultGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                translationParams: translationParams);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out PcLevelMult item,
            TypedParseParams translationParams = default)
        {
            var startPos = frame.Position;
            item = CreateFromBinary(
                frame: frame,
                translationParams: translationParams);
            return startPos != frame.Position;
        }
        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        void IClearable.Clear()
        {
            ((PcLevelMultSetterCommon)((IPcLevelMultGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static new PcLevelMult GetNew()
        {
            return new PcLevelMult();
        }

    }
    #endregion

    #region Interface
    public partial interface IPcLevelMult :
        IANpcLevel,
        ILoquiObjectSetter<IPcLevelMult>,
        IPcLevelMultGetter
    {
        new Single LevelMult { get; set; }
    }

    public partial interface IPcLevelMultGetter :
        IANpcLevelGetter,
        IBinaryItem,
        ILoquiObject<IPcLevelMultGetter>
    {
        static new ILoquiRegistration StaticRegistration => PcLevelMult_Registration.Instance;
        Single LevelMult { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class PcLevelMultMixIn
    {
        public static void Clear(this IPcLevelMult item)
        {
            ((PcLevelMultSetterCommon)((IPcLevelMultGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static PcLevelMult.Mask<bool> GetEqualsMask(
            this IPcLevelMultGetter item,
            IPcLevelMultGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((PcLevelMultCommon)((IPcLevelMultGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string Print(
            this IPcLevelMultGetter item,
            string? name = null,
            PcLevelMult.Mask<bool>? printMask = null)
        {
            return ((PcLevelMultCommon)((IPcLevelMultGetter)item).CommonInstance()!).Print(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void Print(
            this IPcLevelMultGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            PcLevelMult.Mask<bool>? printMask = null)
        {
            ((PcLevelMultCommon)((IPcLevelMultGetter)item).CommonInstance()!).Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IPcLevelMultGetter item,
            IPcLevelMultGetter rhs,
            PcLevelMult.TranslationMask? equalsMask = null)
        {
            return ((PcLevelMultCommon)((IPcLevelMultGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                equalsMask: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IPcLevelMult lhs,
            IPcLevelMultGetter rhs,
            out PcLevelMult.ErrorMask errorMask,
            PcLevelMult.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((PcLevelMultSetterTranslationCommon)((IPcLevelMultGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = PcLevelMult.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IPcLevelMult lhs,
            IPcLevelMultGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((PcLevelMultSetterTranslationCommon)((IPcLevelMultGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static PcLevelMult DeepCopy(
            this IPcLevelMultGetter item,
            PcLevelMult.TranslationMask? copyMask = null)
        {
            return ((PcLevelMultSetterTranslationCommon)((IPcLevelMultGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static PcLevelMult DeepCopy(
            this IPcLevelMultGetter item,
            out PcLevelMult.ErrorMask errorMask,
            PcLevelMult.TranslationMask? copyMask = null)
        {
            return ((PcLevelMultSetterTranslationCommon)((IPcLevelMultGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static PcLevelMult DeepCopy(
            this IPcLevelMultGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((PcLevelMultSetterTranslationCommon)((IPcLevelMultGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IPcLevelMult item,
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            ((PcLevelMultSetterCommon)((IPcLevelMultGetter)item).CommonSetterInstance()!).CopyInFromBinary(
                item: item,
                frame: frame,
                translationParams: translationParams);
        }

        #endregion

    }
    #endregion

}

namespace Mutagen.Bethesda.Skyrim
{
    #region Field Index
    internal enum PcLevelMult_FieldIndex
    {
        LevelMult = 0,
    }
    #endregion

    #region Registration
    internal partial class PcLevelMult_Registration : ILoquiRegistration
    {
        public static readonly PcLevelMult_Registration Instance = new PcLevelMult_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Skyrim.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Skyrim.ProtocolKey,
            msgID: 204,
            version: 0);

        public const string GUID = "dc10b70e-654d-4b0d-ae7f-6f548dfad269";

        public const ushort AdditionalFieldCount = 1;

        public const ushort FieldCount = 1;

        public static readonly Type MaskType = typeof(PcLevelMult.Mask<>);

        public static readonly Type ErrorMaskType = typeof(PcLevelMult.ErrorMask);

        public static readonly Type ClassType = typeof(PcLevelMult);

        public static readonly Type GetterType = typeof(IPcLevelMultGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IPcLevelMult);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Skyrim.PcLevelMult";

        public const string Name = "PcLevelMult";

        public const string Namespace = "Mutagen.Bethesda.Skyrim";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(PcLevelMultBinaryWriteTranslation);
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
    internal partial class PcLevelMultSetterCommon : ANpcLevelSetterCommon
    {
        public new static readonly PcLevelMultSetterCommon Instance = new PcLevelMultSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IPcLevelMult item)
        {
            ClearPartial();
            item.LevelMult = default;
            base.Clear(item);
        }
        
        public override void Clear(IANpcLevel item)
        {
            Clear(item: (IPcLevelMult)item);
        }
        
        #region Mutagen
        public void RemapLinks(IPcLevelMult obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IPcLevelMult item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
            PluginUtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                translationParams: translationParams,
                fillStructs: PcLevelMultBinaryCreateTranslation.FillBinaryStructs);
        }
        
        public override void CopyInFromBinary(
            IANpcLevel item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
            CopyInFromBinary(
                item: (PcLevelMult)item,
                frame: frame,
                translationParams: translationParams);
        }
        
        #endregion
        
    }
    internal partial class PcLevelMultCommon : ANpcLevelCommon
    {
        public new static readonly PcLevelMultCommon Instance = new PcLevelMultCommon();

        public PcLevelMult.Mask<bool> GetEqualsMask(
            IPcLevelMultGetter item,
            IPcLevelMultGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new PcLevelMult.Mask<bool>(false);
            ((PcLevelMultCommon)((IPcLevelMultGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IPcLevelMultGetter item,
            IPcLevelMultGetter rhs,
            PcLevelMult.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            ret.LevelMult = item.LevelMult.EqualsWithin(rhs.LevelMult);
            base.FillEqualsMask(item, rhs, ret, include);
        }
        
        public string Print(
            IPcLevelMultGetter item,
            string? name = null,
            PcLevelMult.Mask<bool>? printMask = null)
        {
            var sb = new StructuredStringBuilder();
            Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
            return sb.ToString();
        }
        
        public void Print(
            IPcLevelMultGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            PcLevelMult.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                sb.AppendLine($"PcLevelMult =>");
            }
            else
            {
                sb.AppendLine($"{name} (PcLevelMult) =>");
            }
            using (sb.Brace())
            {
                ToStringFields(
                    item: item,
                    sb: sb,
                    printMask: printMask);
            }
        }
        
        protected static void ToStringFields(
            IPcLevelMultGetter item,
            StructuredStringBuilder sb,
            PcLevelMult.Mask<bool>? printMask = null)
        {
            ANpcLevelCommon.ToStringFields(
                item: item,
                sb: sb,
                printMask: printMask);
            if (printMask?.LevelMult ?? true)
            {
                sb.AppendItem(item.LevelMult, "LevelMult");
            }
        }
        
        public static PcLevelMult_FieldIndex ConvertFieldIndex(ANpcLevel_FieldIndex index)
        {
            switch (index)
            {
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast()}");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IPcLevelMultGetter? lhs,
            IPcLevelMultGetter? rhs,
            TranslationCrystal? equalsMask)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if (!base.Equals((IANpcLevelGetter)lhs, (IANpcLevelGetter)rhs, equalsMask)) return false;
            if ((equalsMask?.GetShouldTranslate((int)PcLevelMult_FieldIndex.LevelMult) ?? true))
            {
                if (!lhs.LevelMult.EqualsWithin(rhs.LevelMult)) return false;
            }
            return true;
        }
        
        public override bool Equals(
            IANpcLevelGetter? lhs,
            IANpcLevelGetter? rhs,
            TranslationCrystal? equalsMask)
        {
            return Equals(
                lhs: (IPcLevelMultGetter?)lhs,
                rhs: rhs as IPcLevelMultGetter,
                equalsMask: equalsMask);
        }
        
        public virtual int GetHashCode(IPcLevelMultGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.LevelMult);
            hash.Add(base.GetHashCode());
            return hash.ToHashCode();
        }
        
        public override int GetHashCode(IANpcLevelGetter item)
        {
            return GetHashCode(item: (IPcLevelMultGetter)item);
        }
        
        #endregion
        
        
        public override object GetNew()
        {
            return PcLevelMult.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<IFormLinkGetter> EnumerateFormLinks(IPcLevelMultGetter obj)
        {
            yield break;
        }
        
        #endregion
        
    }
    internal partial class PcLevelMultSetterTranslationCommon : ANpcLevelSetterTranslationCommon
    {
        public new static readonly PcLevelMultSetterTranslationCommon Instance = new PcLevelMultSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IPcLevelMult item,
            IPcLevelMultGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                (IANpcLevel)item,
                (IANpcLevelGetter)rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
            if ((copyMask?.GetShouldTranslate((int)PcLevelMult_FieldIndex.LevelMult) ?? true))
            {
                item.LevelMult = rhs.LevelMult;
            }
        }
        
        
        public override void DeepCopyIn(
            IANpcLevel item,
            IANpcLevelGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (IPcLevelMult)item,
                rhs: (IPcLevelMultGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        #endregion
        
        public PcLevelMult DeepCopy(
            IPcLevelMultGetter item,
            PcLevelMult.TranslationMask? copyMask = null)
        {
            PcLevelMult ret = (PcLevelMult)((PcLevelMultCommon)((IPcLevelMultGetter)item).CommonInstance()!).GetNew();
            ((PcLevelMultSetterTranslationCommon)((IPcLevelMultGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public PcLevelMult DeepCopy(
            IPcLevelMultGetter item,
            out PcLevelMult.ErrorMask errorMask,
            PcLevelMult.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            PcLevelMult ret = (PcLevelMult)((PcLevelMultCommon)((IPcLevelMultGetter)item).CommonInstance()!).GetNew();
            ((PcLevelMultSetterTranslationCommon)((IPcLevelMultGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = PcLevelMult.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public PcLevelMult DeepCopy(
            IPcLevelMultGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            PcLevelMult ret = (PcLevelMult)((PcLevelMultCommon)((IPcLevelMultGetter)item).CommonInstance()!).GetNew();
            ((PcLevelMultSetterTranslationCommon)((IPcLevelMultGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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

namespace Mutagen.Bethesda.Skyrim
{
    public partial class PcLevelMult
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => PcLevelMult_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => PcLevelMult_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => PcLevelMultCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterInstance()
        {
            return PcLevelMultSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => PcLevelMultSetterTranslationCommon.Instance;

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Skyrim
{
    public partial class PcLevelMultBinaryWriteTranslation :
        ANpcLevelBinaryWriteTranslation,
        IBinaryWriteTranslator
    {
        public new static readonly PcLevelMultBinaryWriteTranslation Instance = new();

        public static void WriteEmbedded(
            IPcLevelMultGetter item,
            MutagenWriter writer)
        {
        }

        public void Write(
            MutagenWriter writer,
            IPcLevelMultGetter item,
            TypedWriteParams translationParams)
        {
            WriteEmbedded(
                item: item,
                writer: writer);
        }

        public override void Write(
            MutagenWriter writer,
            object item,
            TypedWriteParams translationParams = default)
        {
            Write(
                item: (IPcLevelMultGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

        public override void Write(
            MutagenWriter writer,
            IANpcLevelGetter item,
            TypedWriteParams translationParams)
        {
            Write(
                item: (IPcLevelMultGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

    }

    internal partial class PcLevelMultBinaryCreateTranslation : ANpcLevelBinaryCreateTranslation
    {
        public new static readonly PcLevelMultBinaryCreateTranslation Instance = new PcLevelMultBinaryCreateTranslation();

        public static void FillBinaryStructs(
            IPcLevelMult item,
            MutagenFrame frame)
        {
        }

    }

}
namespace Mutagen.Bethesda.Skyrim
{
    #region Binary Write Mixins
    public static class PcLevelMultBinaryTranslationMixIn
    {
    }
    #endregion


}
namespace Mutagen.Bethesda.Skyrim
{
    internal partial class PcLevelMultBinaryOverlay :
        ANpcLevelBinaryOverlay,
        IPcLevelMultGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => PcLevelMult_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => PcLevelMult_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => PcLevelMultCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => PcLevelMultSetterTranslationCommon.Instance;

        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => PcLevelMultBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((PcLevelMultBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }

        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected PcLevelMultBinaryOverlay(
            MemoryPair memoryPair,
            BinaryOverlayFactoryPackage package)
            : base(
                memoryPair: memoryPair,
                package: package)
        {
            this.CustomCtor();
        }

        public static IPcLevelMultGetter PcLevelMultFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            TypedParseParams translationParams = default)
        {
            stream = ExtractTypelessSubrecordStructMemory(
                stream: stream,
                meta: package.MetaData.Constants,
                translationParams: translationParams,
                memoryPair: out var memoryPair,
                offset: out var offset,
                finalPos: out var finalPos);
            var ret = new PcLevelMultBinaryOverlay(
                memoryPair: memoryPair,
                package: package);
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static IPcLevelMultGetter PcLevelMultFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            TypedParseParams translationParams = default)
        {
            return PcLevelMultFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                translationParams: translationParams);
        }

        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            PcLevelMultMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IPcLevelMultGetter rhs) return false;
            return ((PcLevelMultCommon)((IPcLevelMultGetter)this).CommonInstance()!).Equals(this, rhs, equalsMask: null);
        }

        public bool Equals(IPcLevelMultGetter? obj)
        {
            return ((PcLevelMultCommon)((IPcLevelMultGetter)this).CommonInstance()!).Equals(this, obj, equalsMask: null);
        }

        public override int GetHashCode() => ((PcLevelMultCommon)((IPcLevelMultGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

