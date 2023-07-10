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
using Mutagen.Bethesda.Fallout4.Internals;
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
using Mutagen.Bethesda.Translations.Binary;
using Noggog;
using Noggog.StructuredStrings;
using Noggog.StructuredStrings.CSharp;
using RecordTypeInts = Mutagen.Bethesda.Fallout4.Internals.RecordTypeInts;
using RecordTypes = Mutagen.Bethesda.Fallout4.Internals.RecordTypes;
using System.Buffers.Binary;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reactive.Disposables;
using System.Reactive.Linq;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Fallout4
{
    #region Class
    public partial class DistantLod :
        IDistantLod,
        IEquatable<IDistantLodGetter>,
        ILoquiObjectSetter<DistantLod>
    {
        #region Ctor
        public DistantLod()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region Mesh
        public String Mesh { get; set; } = string.Empty;
        #endregion

        #region To String

        public void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            DistantLodMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IDistantLodGetter rhs) return false;
            return ((DistantLodCommon)((IDistantLodGetter)this).CommonInstance()!).Equals(this, rhs, equalsMask: null);
        }

        public bool Equals(IDistantLodGetter? obj)
        {
            return ((DistantLodCommon)((IDistantLodGetter)this).CommonInstance()!).Equals(this, obj, equalsMask: null);
        }

        public override int GetHashCode() => ((DistantLodCommon)((IDistantLodGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public class Mask<TItem> :
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem Mesh)
            {
                this.Mesh = Mesh;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem Mesh;
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
                if (!object.Equals(this.Mesh, rhs.Mesh)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.Mesh);
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public bool All(Func<TItem, bool> eval)
            {
                if (!eval(this.Mesh)) return false;
                return true;
            }
            #endregion

            #region Any
            public bool Any(Func<TItem, bool> eval)
            {
                if (eval(this.Mesh)) return true;
                return false;
            }
            #endregion

            #region Translate
            public Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new DistantLod.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                obj.Mesh = eval(this.Mesh);
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public string Print(DistantLod.Mask<bool>? printMask = null)
            {
                var sb = new StructuredStringBuilder();
                Print(sb, printMask);
                return sb.ToString();
            }

            public void Print(StructuredStringBuilder sb, DistantLod.Mask<bool>? printMask = null)
            {
                sb.AppendLine($"{nameof(DistantLod.Mask<TItem>)} =>");
                using (sb.Brace())
                {
                    if (printMask?.Mesh ?? true)
                    {
                        sb.AppendItem(Mesh, "Mesh");
                    }
                }
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
            public Exception? Mesh;
            #endregion

            #region IErrorMask
            public object? GetNthMask(int index)
            {
                DistantLod_FieldIndex enu = (DistantLod_FieldIndex)index;
                switch (enu)
                {
                    case DistantLod_FieldIndex.Mesh:
                        return Mesh;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthException(int index, Exception ex)
            {
                DistantLod_FieldIndex enu = (DistantLod_FieldIndex)index;
                switch (enu)
                {
                    case DistantLod_FieldIndex.Mesh:
                        this.Mesh = ex;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthMask(int index, object obj)
            {
                DistantLod_FieldIndex enu = (DistantLod_FieldIndex)index;
                switch (enu)
                {
                    case DistantLod_FieldIndex.Mesh:
                        this.Mesh = (Exception?)obj;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public bool IsInError()
            {
                if (Overall != null) return true;
                if (Mesh != null) return true;
                return false;
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public void Print(StructuredStringBuilder sb, string? name = null)
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
            protected void PrintFillInternal(StructuredStringBuilder sb)
            {
                {
                    sb.AppendItem(Mesh, "Mesh");
                }
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.Mesh = this.Mesh.Combine(rhs.Mesh);
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
            public bool OnOverall;
            public bool Mesh;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
            {
                this.DefaultOn = defaultOn;
                this.OnOverall = onOverall;
                this.Mesh = defaultOn;
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
                ret.Add((Mesh, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected object BinaryWriteTranslator => DistantLodBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((DistantLodBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }
        #region Binary Create
        public static DistantLod CreateFromBinary(
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            var ret = new DistantLod();
            ((DistantLodSetterCommon)((IDistantLodGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                translationParams: translationParams);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out DistantLod item,
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
            ((DistantLodSetterCommon)((IDistantLodGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static DistantLod GetNew()
        {
            return new DistantLod();
        }

    }
    #endregion

    #region Interface
    public partial interface IDistantLod :
        IDistantLodGetter,
        ILoquiObjectSetter<IDistantLod>
    {
        new String Mesh { get; set; }
    }

    public partial interface IDistantLodGetter :
        ILoquiObject,
        IBinaryItem,
        ILoquiObject<IDistantLodGetter>
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object? CommonSetterInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonSetterTranslationInstance();
        static ILoquiRegistration StaticRegistration => DistantLod_Registration.Instance;
        String Mesh { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class DistantLodMixIn
    {
        public static void Clear(this IDistantLod item)
        {
            ((DistantLodSetterCommon)((IDistantLodGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static DistantLod.Mask<bool> GetEqualsMask(
            this IDistantLodGetter item,
            IDistantLodGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((DistantLodCommon)((IDistantLodGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string Print(
            this IDistantLodGetter item,
            string? name = null,
            DistantLod.Mask<bool>? printMask = null)
        {
            return ((DistantLodCommon)((IDistantLodGetter)item).CommonInstance()!).Print(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void Print(
            this IDistantLodGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            DistantLod.Mask<bool>? printMask = null)
        {
            ((DistantLodCommon)((IDistantLodGetter)item).CommonInstance()!).Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IDistantLodGetter item,
            IDistantLodGetter rhs,
            DistantLod.TranslationMask? equalsMask = null)
        {
            return ((DistantLodCommon)((IDistantLodGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                equalsMask: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IDistantLod lhs,
            IDistantLodGetter rhs)
        {
            ((DistantLodSetterTranslationCommon)((IDistantLodGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: default,
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IDistantLod lhs,
            IDistantLodGetter rhs,
            DistantLod.TranslationMask? copyMask = null)
        {
            ((DistantLodSetterTranslationCommon)((IDistantLodGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IDistantLod lhs,
            IDistantLodGetter rhs,
            out DistantLod.ErrorMask errorMask,
            DistantLod.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((DistantLodSetterTranslationCommon)((IDistantLodGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = DistantLod.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IDistantLod lhs,
            IDistantLodGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((DistantLodSetterTranslationCommon)((IDistantLodGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static DistantLod DeepCopy(
            this IDistantLodGetter item,
            DistantLod.TranslationMask? copyMask = null)
        {
            return ((DistantLodSetterTranslationCommon)((IDistantLodGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static DistantLod DeepCopy(
            this IDistantLodGetter item,
            out DistantLod.ErrorMask errorMask,
            DistantLod.TranslationMask? copyMask = null)
        {
            return ((DistantLodSetterTranslationCommon)((IDistantLodGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static DistantLod DeepCopy(
            this IDistantLodGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((DistantLodSetterTranslationCommon)((IDistantLodGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IDistantLod item,
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            ((DistantLodSetterCommon)((IDistantLodGetter)item).CommonSetterInstance()!).CopyInFromBinary(
                item: item,
                frame: frame,
                translationParams: translationParams);
        }

        #endregion

    }
    #endregion

}

namespace Mutagen.Bethesda.Fallout4
{
    #region Field Index
    internal enum DistantLod_FieldIndex
    {
        Mesh = 0,
    }
    #endregion

    #region Registration
    internal partial class DistantLod_Registration : ILoquiRegistration
    {
        public static readonly DistantLod_Registration Instance = new DistantLod_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Fallout4.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Fallout4.ProtocolKey,
            msgID: 331,
            version: 0);

        public const string GUID = "795bff20-ec22-4c22-a3f5-bfb3b2ee105e";

        public const ushort AdditionalFieldCount = 1;

        public const ushort FieldCount = 1;

        public static readonly Type MaskType = typeof(DistantLod.Mask<>);

        public static readonly Type ErrorMaskType = typeof(DistantLod.ErrorMask);

        public static readonly Type ClassType = typeof(DistantLod);

        public static readonly Type GetterType = typeof(IDistantLodGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IDistantLod);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Fallout4.DistantLod";

        public const string Name = "DistantLod";

        public const string Namespace = "Mutagen.Bethesda.Fallout4";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(DistantLodBinaryWriteTranslation);
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
    internal partial class DistantLodSetterCommon
    {
        public static readonly DistantLodSetterCommon Instance = new DistantLodSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IDistantLod item)
        {
            ClearPartial();
            item.Mesh = string.Empty;
        }
        
        #region Mutagen
        public void RemapLinks(IDistantLod obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IDistantLod item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
            PluginUtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                translationParams: translationParams,
                fillStructs: DistantLodBinaryCreateTranslation.FillBinaryStructs);
        }
        
        #endregion
        
    }
    internal partial class DistantLodCommon
    {
        public static readonly DistantLodCommon Instance = new DistantLodCommon();

        public DistantLod.Mask<bool> GetEqualsMask(
            IDistantLodGetter item,
            IDistantLodGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new DistantLod.Mask<bool>(false);
            ((DistantLodCommon)((IDistantLodGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IDistantLodGetter item,
            IDistantLodGetter rhs,
            DistantLod.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            ret.Mesh = string.Equals(item.Mesh, rhs.Mesh);
        }
        
        public string Print(
            IDistantLodGetter item,
            string? name = null,
            DistantLod.Mask<bool>? printMask = null)
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
            IDistantLodGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            DistantLod.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                sb.AppendLine($"DistantLod =>");
            }
            else
            {
                sb.AppendLine($"{name} (DistantLod) =>");
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
            IDistantLodGetter item,
            StructuredStringBuilder sb,
            DistantLod.Mask<bool>? printMask = null)
        {
            if (printMask?.Mesh ?? true)
            {
                sb.AppendItem(item.Mesh, "Mesh");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IDistantLodGetter? lhs,
            IDistantLodGetter? rhs,
            TranslationCrystal? equalsMask)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if ((equalsMask?.GetShouldTranslate((int)DistantLod_FieldIndex.Mesh) ?? true))
            {
                if (!string.Equals(lhs.Mesh, rhs.Mesh)) return false;
            }
            return true;
        }
        
        public virtual int GetHashCode(IDistantLodGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.Mesh);
            return hash.ToHashCode();
        }
        
        #endregion
        
        
        public object GetNew()
        {
            return DistantLod.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<IFormLinkGetter> EnumerateFormLinks(IDistantLodGetter obj)
        {
            yield break;
        }
        
        #endregion
        
    }
    internal partial class DistantLodSetterTranslationCommon
    {
        public static readonly DistantLodSetterTranslationCommon Instance = new DistantLodSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IDistantLod item,
            IDistantLodGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            if ((copyMask?.GetShouldTranslate((int)DistantLod_FieldIndex.Mesh) ?? true))
            {
                item.Mesh = rhs.Mesh;
            }
        }
        
        #endregion
        
        public DistantLod DeepCopy(
            IDistantLodGetter item,
            DistantLod.TranslationMask? copyMask = null)
        {
            DistantLod ret = (DistantLod)((DistantLodCommon)((IDistantLodGetter)item).CommonInstance()!).GetNew();
            ((DistantLodSetterTranslationCommon)((IDistantLodGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public DistantLod DeepCopy(
            IDistantLodGetter item,
            out DistantLod.ErrorMask errorMask,
            DistantLod.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            DistantLod ret = (DistantLod)((DistantLodCommon)((IDistantLodGetter)item).CommonInstance()!).GetNew();
            ((DistantLodSetterTranslationCommon)((IDistantLodGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = DistantLod.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public DistantLod DeepCopy(
            IDistantLodGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            DistantLod ret = (DistantLod)((DistantLodCommon)((IDistantLodGetter)item).CommonInstance()!).GetNew();
            ((DistantLodSetterTranslationCommon)((IDistantLodGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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

namespace Mutagen.Bethesda.Fallout4
{
    public partial class DistantLod
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => DistantLod_Registration.Instance;
        public static ILoquiRegistration StaticRegistration => DistantLod_Registration.Instance;
        [DebuggerStepThrough]
        protected object CommonInstance() => DistantLodCommon.Instance;
        [DebuggerStepThrough]
        protected object CommonSetterInstance()
        {
            return DistantLodSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected object CommonSetterTranslationInstance() => DistantLodSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IDistantLodGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object IDistantLodGetter.CommonSetterInstance() => this.CommonSetterInstance();
        [DebuggerStepThrough]
        object IDistantLodGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Fallout4
{
    public partial class DistantLodBinaryWriteTranslation : IBinaryWriteTranslator
    {
        public static readonly DistantLodBinaryWriteTranslation Instance = new();

        public static void WriteEmbedded(
            IDistantLodGetter item,
            MutagenWriter writer)
        {
            DistantLodBinaryWriteTranslation.WriteBinaryMesh(
                writer: writer,
                item: item);
        }

        public static partial void WriteBinaryMeshCustom(
            MutagenWriter writer,
            IDistantLodGetter item);

        public static void WriteBinaryMesh(
            MutagenWriter writer,
            IDistantLodGetter item)
        {
            WriteBinaryMeshCustom(
                writer: writer,
                item: item);
        }

        public void Write(
            MutagenWriter writer,
            IDistantLodGetter item,
            TypedWriteParams translationParams)
        {
            WriteEmbedded(
                item: item,
                writer: writer);
        }

        public void Write(
            MutagenWriter writer,
            object item,
            TypedWriteParams translationParams = default)
        {
            Write(
                item: (IDistantLodGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

    }

    internal partial class DistantLodBinaryCreateTranslation
    {
        public static readonly DistantLodBinaryCreateTranslation Instance = new DistantLodBinaryCreateTranslation();

        public static void FillBinaryStructs(
            IDistantLod item,
            MutagenFrame frame)
        {
            DistantLodBinaryCreateTranslation.FillBinaryMeshCustom(
                frame: frame,
                item: item);
        }

        public static partial void FillBinaryMeshCustom(
            MutagenFrame frame,
            IDistantLod item);

    }

}
namespace Mutagen.Bethesda.Fallout4
{
    #region Binary Write Mixins
    public static class DistantLodBinaryTranslationMixIn
    {
        public static void WriteToBinary(
            this IDistantLodGetter item,
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((DistantLodBinaryWriteTranslation)item.BinaryWriteTranslator).Write(
                item: item,
                writer: writer,
                translationParams: translationParams);
        }

    }
    #endregion


}
namespace Mutagen.Bethesda.Fallout4
{
    internal partial class DistantLodBinaryOverlay :
        PluginBinaryOverlay,
        IDistantLodGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => DistantLod_Registration.Instance;
        public static ILoquiRegistration StaticRegistration => DistantLod_Registration.Instance;
        [DebuggerStepThrough]
        protected object CommonInstance() => DistantLodCommon.Instance;
        [DebuggerStepThrough]
        protected object CommonSetterTranslationInstance() => DistantLodSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IDistantLodGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object? IDistantLodGetter.CommonSetterInstance() => null;
        [DebuggerStepThrough]
        object IDistantLodGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected object BinaryWriteTranslator => DistantLodBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((DistantLodBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }

        #region Mesh
        public String Mesh { get; private set; } = string.Empty;
        protected int MeshEndingPos;
        partial void CustomMeshEndPos();
        #endregion
        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected DistantLodBinaryOverlay(
            MemoryPair memoryPair,
            BinaryOverlayFactoryPackage package)
            : base(
                memoryPair: memoryPair,
                package: package)
        {
            this.CustomCtor();
        }

        public static IDistantLodGetter DistantLodFactory(
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
            var ret = new DistantLodBinaryOverlay(
                memoryPair: memoryPair,
                package: package);
            ret.CustomMeshEndPos();
            stream.Position += ret.MeshEndingPos;
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static IDistantLodGetter DistantLodFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            TypedParseParams translationParams = default)
        {
            return DistantLodFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                translationParams: translationParams);
        }

        #region To String

        public void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            DistantLodMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IDistantLodGetter rhs) return false;
            return ((DistantLodCommon)((IDistantLodGetter)this).CommonInstance()!).Equals(this, rhs, equalsMask: null);
        }

        public bool Equals(IDistantLodGetter? obj)
        {
            return ((DistantLodCommon)((IDistantLodGetter)this).CommonInstance()!).Equals(this, obj, equalsMask: null);
        }

        public override int GetHashCode() => ((DistantLodCommon)((IDistantLodGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

