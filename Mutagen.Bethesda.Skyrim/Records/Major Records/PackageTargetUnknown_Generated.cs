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
using Mutagen.Bethesda.Skyrim.Internals;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using Mutagen.Bethesda.Skyrim;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Mutagen.Bethesda.Binary;
using System.Buffers.Binary;
using Mutagen.Bethesda.Internals;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Skyrim
{
    #region Class
    public partial class PackageTargetUnknown :
        APackageTarget,
        IPackageTargetUnknown,
        ILoquiObjectSetter<PackageTargetUnknown>,
        IEquatable<IPackageTargetUnknownGetter>
    {
        #region Ctor
        public PackageTargetUnknown()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region Data
        public Int32 Data { get; set; } = default;
        #endregion

        #region To String

        public override void ToString(
            FileGeneration fg,
            string? name = null)
        {
            PackageTargetUnknownMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (!(obj is IPackageTargetUnknownGetter rhs)) return false;
            return ((PackageTargetUnknownCommon)((IPackageTargetUnknownGetter)this).CommonInstance()!).Equals(this, rhs);
        }

        public bool Equals(IPackageTargetUnknownGetter? obj)
        {
            return ((PackageTargetUnknownCommon)((IPackageTargetUnknownGetter)this).CommonInstance()!).Equals(this, obj);
        }

        public override int GetHashCode() => ((PackageTargetUnknownCommon)((IPackageTargetUnknownGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public new class Mask<TItem> :
            APackageTarget.Mask<TItem>,
            IMask<TItem>,
            IEquatable<Mask<TItem>>
        {
            #region Ctors
            public Mask(TItem initialValue)
            : base(initialValue)
            {
                this.Data = initialValue;
            }

            public Mask(
                TItem CountOrDistance,
                TItem Data)
            : base(CountOrDistance: CountOrDistance)
            {
                this.Data = Data;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem Data;
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
                if (!object.Equals(this.Data, rhs.Data)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.Data);
                hash.Add(base.GetHashCode());
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public override bool All(Func<TItem, bool> eval)
            {
                if (!base.All(eval)) return false;
                if (!eval(this.Data)) return false;
                return true;
            }
            #endregion

            #region Any
            public override bool Any(Func<TItem, bool> eval)
            {
                if (base.Any(eval)) return true;
                if (eval(this.Data)) return true;
                return false;
            }
            #endregion

            #region Translate
            public new Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new PackageTargetUnknown.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                base.Translate_InternalFill(obj, eval);
                obj.Data = eval(this.Data);
            }
            #endregion

            #region To String
            public override string ToString()
            {
                return ToString(printMask: null);
            }

            public string ToString(PackageTargetUnknown.Mask<bool>? printMask = null)
            {
                var fg = new FileGeneration();
                ToString(fg, printMask);
                return fg.ToString();
            }

            public void ToString(FileGeneration fg, PackageTargetUnknown.Mask<bool>? printMask = null)
            {
                fg.AppendLine($"{nameof(PackageTargetUnknown.Mask<TItem>)} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
                    if (printMask?.Data ?? true)
                    {
                        fg.AppendItem(Data, "Data");
                    }
                }
                fg.AppendLine("]");
            }
            #endregion

        }

        public new class ErrorMask :
            APackageTarget.ErrorMask,
            IErrorMask<ErrorMask>
        {
            #region Members
            public Exception? Data;
            #endregion

            #region IErrorMask
            public override object? GetNthMask(int index)
            {
                PackageTargetUnknown_FieldIndex enu = (PackageTargetUnknown_FieldIndex)index;
                switch (enu)
                {
                    case PackageTargetUnknown_FieldIndex.Data:
                        return Data;
                    default:
                        return base.GetNthMask(index);
                }
            }

            public override void SetNthException(int index, Exception ex)
            {
                PackageTargetUnknown_FieldIndex enu = (PackageTargetUnknown_FieldIndex)index;
                switch (enu)
                {
                    case PackageTargetUnknown_FieldIndex.Data:
                        this.Data = ex;
                        break;
                    default:
                        base.SetNthException(index, ex);
                        break;
                }
            }

            public override void SetNthMask(int index, object obj)
            {
                PackageTargetUnknown_FieldIndex enu = (PackageTargetUnknown_FieldIndex)index;
                switch (enu)
                {
                    case PackageTargetUnknown_FieldIndex.Data:
                        this.Data = (Exception?)obj;
                        break;
                    default:
                        base.SetNthMask(index, obj);
                        break;
                }
            }

            public override bool IsInError()
            {
                if (Overall != null) return true;
                if (Data != null) return true;
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

            public override void ToString(FileGeneration fg, string? name = null)
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
            protected override void ToString_FillInternal(FileGeneration fg)
            {
                base.ToString_FillInternal(fg);
                fg.AppendItem(Data, "Data");
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.Data = this.Data.Combine(rhs.Data);
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
            APackageTarget.TranslationMask,
            ITranslationMask
        {
            #region Members
            public bool Data;
            #endregion

            #region Ctors
            public TranslationMask(bool defaultOn)
                : base(defaultOn)
            {
                this.Data = defaultOn;
            }

            #endregion

            protected override void GetCrystal(List<(bool On, TranslationCrystal? SubCrystal)> ret)
            {
                base.GetCrystal(ret);
                ret.Add((Data, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn);
            }

        }
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => PackageTargetUnknownBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((PackageTargetUnknownBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }
        #region Binary Create
        public new static PackageTargetUnknown CreateFromBinary(
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var ret = new PackageTargetUnknown();
            ((PackageTargetUnknownSetterCommon)((IPackageTargetUnknownGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                recordTypeConverter: recordTypeConverter);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out PackageTargetUnknown item,
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
            ((PackageTargetUnknownSetterCommon)((IPackageTargetUnknownGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static new PackageTargetUnknown GetNew()
        {
            return new PackageTargetUnknown();
        }

    }
    #endregion

    #region Interface
    public partial interface IPackageTargetUnknown :
        IPackageTargetUnknownGetter,
        IAPackageTarget,
        ILoquiObjectSetter<IPackageTargetUnknown>
    {
        new Int32 Data { get; set; }
    }

    public partial interface IPackageTargetUnknownGetter :
        IAPackageTargetGetter,
        ILoquiObject<IPackageTargetUnknownGetter>,
        IBinaryItem
    {
        static new ILoquiRegistration Registration => PackageTargetUnknown_Registration.Instance;
        Int32 Data { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class PackageTargetUnknownMixIn
    {
        public static void Clear(this IPackageTargetUnknown item)
        {
            ((PackageTargetUnknownSetterCommon)((IPackageTargetUnknownGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static PackageTargetUnknown.Mask<bool> GetEqualsMask(
            this IPackageTargetUnknownGetter item,
            IPackageTargetUnknownGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((PackageTargetUnknownCommon)((IPackageTargetUnknownGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string ToString(
            this IPackageTargetUnknownGetter item,
            string? name = null,
            PackageTargetUnknown.Mask<bool>? printMask = null)
        {
            return ((PackageTargetUnknownCommon)((IPackageTargetUnknownGetter)item).CommonInstance()!).ToString(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void ToString(
            this IPackageTargetUnknownGetter item,
            FileGeneration fg,
            string? name = null,
            PackageTargetUnknown.Mask<bool>? printMask = null)
        {
            ((PackageTargetUnknownCommon)((IPackageTargetUnknownGetter)item).CommonInstance()!).ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IPackageTargetUnknownGetter item,
            IPackageTargetUnknownGetter rhs)
        {
            return ((PackageTargetUnknownCommon)((IPackageTargetUnknownGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs);
        }

        public static void DeepCopyIn(
            this IPackageTargetUnknown lhs,
            IPackageTargetUnknownGetter rhs,
            out PackageTargetUnknown.ErrorMask errorMask,
            PackageTargetUnknown.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((PackageTargetUnknownSetterTranslationCommon)((IPackageTargetUnknownGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = PackageTargetUnknown.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IPackageTargetUnknown lhs,
            IPackageTargetUnknownGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((PackageTargetUnknownSetterTranslationCommon)((IPackageTargetUnknownGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static PackageTargetUnknown DeepCopy(
            this IPackageTargetUnknownGetter item,
            PackageTargetUnknown.TranslationMask? copyMask = null)
        {
            return ((PackageTargetUnknownSetterTranslationCommon)((IPackageTargetUnknownGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static PackageTargetUnknown DeepCopy(
            this IPackageTargetUnknownGetter item,
            out PackageTargetUnknown.ErrorMask errorMask,
            PackageTargetUnknown.TranslationMask? copyMask = null)
        {
            return ((PackageTargetUnknownSetterTranslationCommon)((IPackageTargetUnknownGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static PackageTargetUnknown DeepCopy(
            this IPackageTargetUnknownGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((PackageTargetUnknownSetterTranslationCommon)((IPackageTargetUnknownGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IPackageTargetUnknown item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((PackageTargetUnknownSetterCommon)((IPackageTargetUnknownGetter)item).CommonSetterInstance()!).CopyInFromBinary(
                item: item,
                frame: frame,
                recordTypeConverter: recordTypeConverter);
        }

        #endregion

    }
    #endregion

}

namespace Mutagen.Bethesda.Skyrim.Internals
{
    #region Field Index
    public enum PackageTargetUnknown_FieldIndex
    {
        CountOrDistance = 0,
        Data = 1,
    }
    #endregion

    #region Registration
    public partial class PackageTargetUnknown_Registration : ILoquiRegistration
    {
        public static readonly PackageTargetUnknown_Registration Instance = new PackageTargetUnknown_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Skyrim.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Skyrim.ProtocolKey,
            msgID: 381,
            version: 0);

        public const string GUID = "9fc66bed-a089-4e72-bdb2-a542bbf97818";

        public const ushort AdditionalFieldCount = 1;

        public const ushort FieldCount = 2;

        public static readonly Type MaskType = typeof(PackageTargetUnknown.Mask<>);

        public static readonly Type ErrorMaskType = typeof(PackageTargetUnknown.ErrorMask);

        public static readonly Type ClassType = typeof(PackageTargetUnknown);

        public static readonly Type GetterType = typeof(IPackageTargetUnknownGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IPackageTargetUnknown);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Skyrim.PackageTargetUnknown";

        public const string Name = "PackageTargetUnknown";

        public const string Namespace = "Mutagen.Bethesda.Skyrim";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(PackageTargetUnknownBinaryWriteTranslation);
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
    public partial class PackageTargetUnknownSetterCommon : APackageTargetSetterCommon
    {
        public new static readonly PackageTargetUnknownSetterCommon Instance = new PackageTargetUnknownSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IPackageTargetUnknown item)
        {
            ClearPartial();
            item.Data = default;
            base.Clear(item);
        }
        
        public override void Clear(IAPackageTarget item)
        {
            Clear(item: (IPackageTargetUnknown)item);
        }
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IPackageTargetUnknown item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            UtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                recordTypeConverter: recordTypeConverter,
                fillStructs: PackageTargetUnknownBinaryCreateTranslation.FillBinaryStructs);
        }
        
        public override void CopyInFromBinary(
            IAPackageTarget item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            CopyInFromBinary(
                item: (PackageTargetUnknown)item,
                frame: frame,
                recordTypeConverter: recordTypeConverter);
        }
        
        #endregion
        
    }
    public partial class PackageTargetUnknownCommon : APackageTargetCommon
    {
        public new static readonly PackageTargetUnknownCommon Instance = new PackageTargetUnknownCommon();

        public PackageTargetUnknown.Mask<bool> GetEqualsMask(
            IPackageTargetUnknownGetter item,
            IPackageTargetUnknownGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new PackageTargetUnknown.Mask<bool>(false);
            ((PackageTargetUnknownCommon)((IPackageTargetUnknownGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IPackageTargetUnknownGetter item,
            IPackageTargetUnknownGetter rhs,
            PackageTargetUnknown.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
            ret.Data = item.Data == rhs.Data;
            base.FillEqualsMask(item, rhs, ret, include);
        }
        
        public string ToString(
            IPackageTargetUnknownGetter item,
            string? name = null,
            PackageTargetUnknown.Mask<bool>? printMask = null)
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
            IPackageTargetUnknownGetter item,
            FileGeneration fg,
            string? name = null,
            PackageTargetUnknown.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                fg.AppendLine($"PackageTargetUnknown =>");
            }
            else
            {
                fg.AppendLine($"{name} (PackageTargetUnknown) =>");
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
            IPackageTargetUnknownGetter item,
            FileGeneration fg,
            PackageTargetUnknown.Mask<bool>? printMask = null)
        {
            APackageTargetCommon.ToStringFields(
                item: item,
                fg: fg,
                printMask: printMask);
            if (printMask?.Data ?? true)
            {
                fg.AppendItem(item.Data, "Data");
            }
        }
        
        public static PackageTargetUnknown_FieldIndex ConvertFieldIndex(APackageTarget_FieldIndex index)
        {
            switch (index)
            {
                case APackageTarget_FieldIndex.CountOrDistance:
                    return (PackageTargetUnknown_FieldIndex)((int)index);
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast_Enum_Only()}");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IPackageTargetUnknownGetter? lhs,
            IPackageTargetUnknownGetter? rhs)
        {
            if (lhs == null && rhs == null) return false;
            if (lhs == null || rhs == null) return false;
            if (!base.Equals((IAPackageTargetGetter)lhs, (IAPackageTargetGetter)rhs)) return false;
            if (lhs.Data != rhs.Data) return false;
            return true;
        }
        
        public override bool Equals(
            IAPackageTargetGetter? lhs,
            IAPackageTargetGetter? rhs)
        {
            return Equals(
                lhs: (IPackageTargetUnknownGetter?)lhs,
                rhs: rhs as IPackageTargetUnknownGetter);
        }
        
        public virtual int GetHashCode(IPackageTargetUnknownGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.Data);
            hash.Add(base.GetHashCode());
            return hash.ToHashCode();
        }
        
        public override int GetHashCode(IAPackageTargetGetter item)
        {
            return GetHashCode(item: (IPackageTargetUnknownGetter)item);
        }
        
        #endregion
        
        
        public override object GetNew()
        {
            return PackageTargetUnknown.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<FormKey> GetLinkFormKeys(IPackageTargetUnknownGetter obj)
        {
            foreach (var item in base.GetLinkFormKeys(obj))
            {
                yield return item;
            }
            yield break;
        }
        
        public void RemapLinks(IPackageTargetUnknownGetter obj, IReadOnlyDictionary<FormKey, FormKey> mapping) => throw new NotImplementedException();
        #endregion
        
    }
    public partial class PackageTargetUnknownSetterTranslationCommon : APackageTargetSetterTranslationCommon
    {
        public new static readonly PackageTargetUnknownSetterTranslationCommon Instance = new PackageTargetUnknownSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IPackageTargetUnknown item,
            IPackageTargetUnknownGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                (IAPackageTarget)item,
                (IAPackageTargetGetter)rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
            if ((copyMask?.GetShouldTranslate((int)PackageTargetUnknown_FieldIndex.Data) ?? true))
            {
                item.Data = rhs.Data;
            }
        }
        
        
        public override void DeepCopyIn(
            IAPackageTarget item,
            IAPackageTargetGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (IPackageTargetUnknown)item,
                rhs: (IPackageTargetUnknownGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        #endregion
        
        public PackageTargetUnknown DeepCopy(
            IPackageTargetUnknownGetter item,
            PackageTargetUnknown.TranslationMask? copyMask = null)
        {
            PackageTargetUnknown ret = (PackageTargetUnknown)((PackageTargetUnknownCommon)((IPackageTargetUnknownGetter)item).CommonInstance()!).GetNew();
            ((PackageTargetUnknownSetterTranslationCommon)((IPackageTargetUnknownGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public PackageTargetUnknown DeepCopy(
            IPackageTargetUnknownGetter item,
            out PackageTargetUnknown.ErrorMask errorMask,
            PackageTargetUnknown.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            PackageTargetUnknown ret = (PackageTargetUnknown)((PackageTargetUnknownCommon)((IPackageTargetUnknownGetter)item).CommonInstance()!).GetNew();
            ((PackageTargetUnknownSetterTranslationCommon)((IPackageTargetUnknownGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = PackageTargetUnknown.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public PackageTargetUnknown DeepCopy(
            IPackageTargetUnknownGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            PackageTargetUnknown ret = (PackageTargetUnknown)((PackageTargetUnknownCommon)((IPackageTargetUnknownGetter)item).CommonInstance()!).GetNew();
            ((PackageTargetUnknownSetterTranslationCommon)((IPackageTargetUnknownGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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
    public partial class PackageTargetUnknown
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => PackageTargetUnknown_Registration.Instance;
        public new static PackageTargetUnknown_Registration Registration => PackageTargetUnknown_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => PackageTargetUnknownCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterInstance()
        {
            return PackageTargetUnknownSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => PackageTargetUnknownSetterTranslationCommon.Instance;

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class PackageTargetUnknownBinaryWriteTranslation :
        APackageTargetBinaryWriteTranslation,
        IBinaryWriteTranslator
    {
        public new readonly static PackageTargetUnknownBinaryWriteTranslation Instance = new PackageTargetUnknownBinaryWriteTranslation();

        public static void WriteEmbedded(
            IPackageTargetUnknownGetter item,
            MutagenWriter writer)
        {
            APackageTargetBinaryWriteTranslation.WriteEmbedded(
                item: item,
                writer: writer);
            writer.Write(item.Data);
        }

        public void Write(
            MutagenWriter writer,
            IPackageTargetUnknownGetter item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            WriteEmbedded(
                item: item,
                writer: writer);
        }

        public override void Write(
            MutagenWriter writer,
            object item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            Write(
                item: (IPackageTargetUnknownGetter)item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

        public override void Write(
            MutagenWriter writer,
            IAPackageTargetGetter item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            Write(
                item: (IPackageTargetUnknownGetter)item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

    }

    public partial class PackageTargetUnknownBinaryCreateTranslation : APackageTargetBinaryCreateTranslation
    {
        public new readonly static PackageTargetUnknownBinaryCreateTranslation Instance = new PackageTargetUnknownBinaryCreateTranslation();

        public static void FillBinaryStructs(
            IPackageTargetUnknown item,
            MutagenFrame frame)
        {
            APackageTargetBinaryCreateTranslation.FillBinaryStructs(
                item: item,
                frame: frame);
            item.Data = frame.ReadInt32();
        }

    }

}
namespace Mutagen.Bethesda.Skyrim
{
    #region Binary Write Mixins
    public static class PackageTargetUnknownBinaryTranslationMixIn
    {
    }
    #endregion


}
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class PackageTargetUnknownBinaryOverlay :
        APackageTargetBinaryOverlay,
        IPackageTargetUnknownGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => PackageTargetUnknown_Registration.Instance;
        public new static PackageTargetUnknown_Registration Registration => PackageTargetUnknown_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => PackageTargetUnknownCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => PackageTargetUnknownSetterTranslationCommon.Instance;

        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => PackageTargetUnknownBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((PackageTargetUnknownBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

        public Int32 Data => BinaryPrimitives.ReadInt32LittleEndian(_data.Slice(0xC, 0x4));
        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected PackageTargetUnknownBinaryOverlay(
            ReadOnlyMemorySlice<byte> bytes,
            BinaryOverlayFactoryPackage package)
            : base(
                bytes: bytes,
                package: package)
        {
            this.CustomCtor();
        }

        public static PackageTargetUnknownBinaryOverlay PackageTargetUnknownFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var ret = new PackageTargetUnknownBinaryOverlay(
                bytes: stream.RemainingMemory.Slice(0, 0x10),
                package: package);
            int offset = stream.Position;
            stream.Position += 0x10;
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static PackageTargetUnknownBinaryOverlay PackageTargetUnknownFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            RecordTypeConverter? recordTypeConverter = null)
        {
            return PackageTargetUnknownFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                recordTypeConverter: recordTypeConverter);
        }

        #region To String

        public override void ToString(
            FileGeneration fg,
            string? name = null)
        {
            PackageTargetUnknownMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (!(obj is IPackageTargetUnknownGetter rhs)) return false;
            return ((PackageTargetUnknownCommon)((IPackageTargetUnknownGetter)this).CommonInstance()!).Equals(this, rhs);
        }

        public bool Equals(IPackageTargetUnknownGetter? obj)
        {
            return ((PackageTargetUnknownCommon)((IPackageTargetUnknownGetter)this).CommonInstance()!).Equals(this, obj);
        }

        public override int GetHashCode() => ((PackageTargetUnknownCommon)((IPackageTargetUnknownGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

