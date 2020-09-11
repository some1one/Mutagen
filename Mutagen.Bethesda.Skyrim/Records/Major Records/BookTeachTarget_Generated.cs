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
    public abstract partial class BookTeachTarget :
        IBookTeachTarget,
        ILoquiObjectSetter<BookTeachTarget>,
        IEquatable<IBookTeachTargetGetter>
    {
        #region Ctor
        public BookTeachTarget()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion


        #region To String

        public virtual void ToString(
            FileGeneration fg,
            string? name = null)
        {
            BookTeachTargetMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (!(obj is IBookTeachTargetGetter rhs)) return false;
            return ((BookTeachTargetCommon)((IBookTeachTargetGetter)this).CommonInstance()!).Equals(this, rhs);
        }

        public bool Equals(IBookTeachTargetGetter? obj)
        {
            return ((BookTeachTargetCommon)((IBookTeachTargetGetter)this).CommonInstance()!).Equals(this, obj);
        }

        public override int GetHashCode() => ((BookTeachTargetCommon)((IBookTeachTargetGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public class Mask<TItem> :
            IMask<TItem>,
            IEquatable<Mask<TItem>>
        {
            #region Ctors
            public Mask(TItem initialValue)
            {
            }


            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

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
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public virtual bool All(Func<TItem, bool> eval)
            {
                return true;
            }
            #endregion

            #region Any
            public virtual bool Any(Func<TItem, bool> eval)
            {
                return false;
            }
            #endregion

            #region Translate
            public Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new BookTeachTarget.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
            }
            #endregion

            #region To String
            public override string ToString()
            {
                return ToString(printMask: null);
            }

            public string ToString(BookTeachTarget.Mask<bool>? printMask = null)
            {
                var fg = new FileGeneration();
                ToString(fg, printMask);
                return fg.ToString();
            }

            public void ToString(FileGeneration fg, BookTeachTarget.Mask<bool>? printMask = null)
            {
                fg.AppendLine($"{nameof(BookTeachTarget.Mask<TItem>)} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
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
            #endregion

            #region IErrorMask
            public virtual object? GetNthMask(int index)
            {
                BookTeachTarget_FieldIndex enu = (BookTeachTarget_FieldIndex)index;
                switch (enu)
                {
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public virtual void SetNthException(int index, Exception ex)
            {
                BookTeachTarget_FieldIndex enu = (BookTeachTarget_FieldIndex)index;
                switch (enu)
                {
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public virtual void SetNthMask(int index, object obj)
            {
                BookTeachTarget_FieldIndex enu = (BookTeachTarget_FieldIndex)index;
                switch (enu)
                {
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public virtual bool IsInError()
            {
                if (Overall != null) return true;
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

            public virtual void ToString(FileGeneration fg, string? name = null)
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
            protected virtual void ToString_FillInternal(FileGeneration fg)
            {
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
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
            #endregion

            #region Ctors
            public TranslationMask(bool defaultOn)
            {
                this.DefaultOn = defaultOn;
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

            protected virtual void GetCrystal(List<(bool On, TranslationCrystal? SubCrystal)> ret)
            {
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn);
            }

        }
        #endregion

        #region Mutagen
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected virtual IEnumerable<FormKey> LinkFormKeys => BookTeachTargetCommon.Instance.GetLinkFormKeys(this);
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IEnumerable<FormKey> ILinkedFormKeyContainerGetter.LinkFormKeys => BookTeachTargetCommon.Instance.GetLinkFormKeys(this);
        protected virtual void RemapLinks(IReadOnlyDictionary<FormKey, FormKey> mapping) => BookTeachTargetCommon.Instance.RemapLinks(this, mapping);
        void ILinkedFormKeyContainer.RemapLinks(IReadOnlyDictionary<FormKey, FormKey> mapping) => BookTeachTargetCommon.Instance.RemapLinks(this, mapping);
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected virtual object BinaryWriteTranslator => BookTeachTargetBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((BookTeachTargetBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }
        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        void IClearable.Clear()
        {
            ((BookTeachTargetSetterCommon)((IBookTeachTargetGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static BookTeachTarget GetNew()
        {
            throw new ArgumentException("New called on an abstract class.");
        }

    }
    #endregion

    #region Interface
    public partial interface IBookTeachTarget :
        IBookTeachTargetGetter,
        ILoquiObjectSetter<IBookTeachTarget>,
        ILinkedFormKeyContainer
    {
    }

    public partial interface IBookTeachTargetGetter :
        ILoquiObject,
        ILoquiObject<IBookTeachTargetGetter>,
        ILinkedFormKeyContainerGetter,
        IBinaryItem
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object? CommonSetterInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonSetterTranslationInstance();
        static ILoquiRegistration Registration => BookTeachTarget_Registration.Instance;

    }

    #endregion

    #region Common MixIn
    public static partial class BookTeachTargetMixIn
    {
        public static void Clear(this IBookTeachTarget item)
        {
            ((BookTeachTargetSetterCommon)((IBookTeachTargetGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static BookTeachTarget.Mask<bool> GetEqualsMask(
            this IBookTeachTargetGetter item,
            IBookTeachTargetGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((BookTeachTargetCommon)((IBookTeachTargetGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string ToString(
            this IBookTeachTargetGetter item,
            string? name = null,
            BookTeachTarget.Mask<bool>? printMask = null)
        {
            return ((BookTeachTargetCommon)((IBookTeachTargetGetter)item).CommonInstance()!).ToString(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void ToString(
            this IBookTeachTargetGetter item,
            FileGeneration fg,
            string? name = null,
            BookTeachTarget.Mask<bool>? printMask = null)
        {
            ((BookTeachTargetCommon)((IBookTeachTargetGetter)item).CommonInstance()!).ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IBookTeachTargetGetter item,
            IBookTeachTargetGetter rhs)
        {
            return ((BookTeachTargetCommon)((IBookTeachTargetGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs);
        }

        public static void DeepCopyIn(
            this IBookTeachTarget lhs,
            IBookTeachTargetGetter rhs)
        {
            ((BookTeachTargetSetterTranslationCommon)((IBookTeachTargetGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: default,
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IBookTeachTarget lhs,
            IBookTeachTargetGetter rhs,
            BookTeachTarget.TranslationMask? copyMask = null)
        {
            ((BookTeachTargetSetterTranslationCommon)((IBookTeachTargetGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IBookTeachTarget lhs,
            IBookTeachTargetGetter rhs,
            out BookTeachTarget.ErrorMask errorMask,
            BookTeachTarget.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((BookTeachTargetSetterTranslationCommon)((IBookTeachTargetGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = BookTeachTarget.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IBookTeachTarget lhs,
            IBookTeachTargetGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((BookTeachTargetSetterTranslationCommon)((IBookTeachTargetGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static BookTeachTarget DeepCopy(
            this IBookTeachTargetGetter item,
            BookTeachTarget.TranslationMask? copyMask = null)
        {
            return ((BookTeachTargetSetterTranslationCommon)((IBookTeachTargetGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static BookTeachTarget DeepCopy(
            this IBookTeachTargetGetter item,
            out BookTeachTarget.ErrorMask errorMask,
            BookTeachTarget.TranslationMask? copyMask = null)
        {
            return ((BookTeachTargetSetterTranslationCommon)((IBookTeachTargetGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static BookTeachTarget DeepCopy(
            this IBookTeachTargetGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((BookTeachTargetSetterTranslationCommon)((IBookTeachTargetGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IBookTeachTarget item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((BookTeachTargetSetterCommon)((IBookTeachTargetGetter)item).CommonSetterInstance()!).CopyInFromBinary(
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
    public enum BookTeachTarget_FieldIndex
    {
    }
    #endregion

    #region Registration
    public partial class BookTeachTarget_Registration : ILoquiRegistration
    {
        public static readonly BookTeachTarget_Registration Instance = new BookTeachTarget_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Skyrim.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Skyrim.ProtocolKey,
            msgID: 156,
            version: 0);

        public const string GUID = "a95689cb-bc18-4276-b852-755a8d728d04";

        public const ushort AdditionalFieldCount = 0;

        public const ushort FieldCount = 0;

        public static readonly Type MaskType = typeof(BookTeachTarget.Mask<>);

        public static readonly Type ErrorMaskType = typeof(BookTeachTarget.ErrorMask);

        public static readonly Type ClassType = typeof(BookTeachTarget);

        public static readonly Type GetterType = typeof(IBookTeachTargetGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IBookTeachTarget);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Skyrim.BookTeachTarget";

        public const string Name = "BookTeachTarget";

        public const string Namespace = "Mutagen.Bethesda.Skyrim";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(BookTeachTargetBinaryWriteTranslation);
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
    public partial class BookTeachTargetSetterCommon
    {
        public static readonly BookTeachTargetSetterCommon Instance = new BookTeachTargetSetterCommon();

        partial void ClearPartial();
        
        public virtual void Clear(IBookTeachTarget item)
        {
            ClearPartial();
        }
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IBookTeachTarget item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
        }
        
        #endregion
        
    }
    public partial class BookTeachTargetCommon
    {
        public static readonly BookTeachTargetCommon Instance = new BookTeachTargetCommon();

        public BookTeachTarget.Mask<bool> GetEqualsMask(
            IBookTeachTargetGetter item,
            IBookTeachTargetGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new BookTeachTarget.Mask<bool>(false);
            ((BookTeachTargetCommon)((IBookTeachTargetGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IBookTeachTargetGetter item,
            IBookTeachTargetGetter rhs,
            BookTeachTarget.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
        }
        
        public string ToString(
            IBookTeachTargetGetter item,
            string? name = null,
            BookTeachTarget.Mask<bool>? printMask = null)
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
            IBookTeachTargetGetter item,
            FileGeneration fg,
            string? name = null,
            BookTeachTarget.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                fg.AppendLine($"BookTeachTarget =>");
            }
            else
            {
                fg.AppendLine($"{name} (BookTeachTarget) =>");
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
            IBookTeachTargetGetter item,
            FileGeneration fg,
            BookTeachTarget.Mask<bool>? printMask = null)
        {
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IBookTeachTargetGetter? lhs,
            IBookTeachTargetGetter? rhs)
        {
            if (lhs == null && rhs == null) return false;
            if (lhs == null || rhs == null) return false;
            return true;
        }
        
        public virtual int GetHashCode(IBookTeachTargetGetter item)
        {
            var hash = new HashCode();
            return hash.ToHashCode();
        }
        
        #endregion
        
        
        public virtual object GetNew()
        {
            return BookTeachTarget.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<FormKey> GetLinkFormKeys(IBookTeachTargetGetter obj)
        {
            yield break;
        }
        
        public void RemapLinks(IBookTeachTargetGetter obj, IReadOnlyDictionary<FormKey, FormKey> mapping) => throw new NotImplementedException();
        #endregion
        
    }
    public partial class BookTeachTargetSetterTranslationCommon
    {
        public static readonly BookTeachTargetSetterTranslationCommon Instance = new BookTeachTargetSetterTranslationCommon();

        #region DeepCopyIn
        public virtual void DeepCopyIn(
            IBookTeachTarget item,
            IBookTeachTargetGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
        }
        
        #endregion
        
        public BookTeachTarget DeepCopy(
            IBookTeachTargetGetter item,
            BookTeachTarget.TranslationMask? copyMask = null)
        {
            BookTeachTarget ret = (BookTeachTarget)((BookTeachTargetCommon)((IBookTeachTargetGetter)item).CommonInstance()!).GetNew();
            ((BookTeachTargetSetterTranslationCommon)((IBookTeachTargetGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public BookTeachTarget DeepCopy(
            IBookTeachTargetGetter item,
            out BookTeachTarget.ErrorMask errorMask,
            BookTeachTarget.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            BookTeachTarget ret = (BookTeachTarget)((BookTeachTargetCommon)((IBookTeachTargetGetter)item).CommonInstance()!).GetNew();
            ((BookTeachTargetSetterTranslationCommon)((IBookTeachTargetGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = BookTeachTarget.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public BookTeachTarget DeepCopy(
            IBookTeachTargetGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            BookTeachTarget ret = (BookTeachTarget)((BookTeachTargetCommon)((IBookTeachTargetGetter)item).CommonInstance()!).GetNew();
            ((BookTeachTargetSetterTranslationCommon)((IBookTeachTargetGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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
    public partial class BookTeachTarget
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => BookTeachTarget_Registration.Instance;
        public static BookTeachTarget_Registration Registration => BookTeachTarget_Registration.Instance;
        [DebuggerStepThrough]
        protected virtual object CommonInstance() => BookTeachTargetCommon.Instance;
        [DebuggerStepThrough]
        protected virtual object CommonSetterInstance()
        {
            return BookTeachTargetSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected virtual object CommonSetterTranslationInstance() => BookTeachTargetSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IBookTeachTargetGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object IBookTeachTargetGetter.CommonSetterInstance() => this.CommonSetterInstance();
        [DebuggerStepThrough]
        object IBookTeachTargetGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class BookTeachTargetBinaryWriteTranslation : IBinaryWriteTranslator
    {
        public readonly static BookTeachTargetBinaryWriteTranslation Instance = new BookTeachTargetBinaryWriteTranslation();

        public virtual void Write(
            MutagenWriter writer,
            IBookTeachTargetGetter item,
            RecordTypeConverter? recordTypeConverter = null)
        {
        }

        public virtual void Write(
            MutagenWriter writer,
            object item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            Write(
                item: (IBookTeachTargetGetter)item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

    }

    public partial class BookTeachTargetBinaryCreateTranslation
    {
        public readonly static BookTeachTargetBinaryCreateTranslation Instance = new BookTeachTargetBinaryCreateTranslation();

    }

}
namespace Mutagen.Bethesda.Skyrim
{
    #region Binary Write Mixins
    public static class BookTeachTargetBinaryTranslationMixIn
    {
        public static void WriteToBinary(
            this IBookTeachTargetGetter item,
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((BookTeachTargetBinaryWriteTranslation)item.BinaryWriteTranslator).Write(
                item: item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

    }
    #endregion


}
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class BookTeachTargetBinaryOverlay :
        BinaryOverlay,
        IBookTeachTargetGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => BookTeachTarget_Registration.Instance;
        public static BookTeachTarget_Registration Registration => BookTeachTarget_Registration.Instance;
        [DebuggerStepThrough]
        protected virtual object CommonInstance() => BookTeachTargetCommon.Instance;
        [DebuggerStepThrough]
        protected virtual object CommonSetterTranslationInstance() => BookTeachTargetSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IBookTeachTargetGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object? IBookTeachTargetGetter.CommonSetterInstance() => null;
        [DebuggerStepThrough]
        object IBookTeachTargetGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected virtual IEnumerable<FormKey> LinkFormKeys => BookTeachTargetCommon.Instance.GetLinkFormKeys(this);
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IEnumerable<FormKey> ILinkedFormKeyContainerGetter.LinkFormKeys => BookTeachTargetCommon.Instance.GetLinkFormKeys(this);
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected virtual object BinaryWriteTranslator => BookTeachTargetBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((BookTeachTargetBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected BookTeachTargetBinaryOverlay(
            ReadOnlyMemorySlice<byte> bytes,
            BinaryOverlayFactoryPackage package)
            : base(
                bytes: bytes,
                package: package)
        {
            this.CustomCtor();
        }


        #region To String

        public virtual void ToString(
            FileGeneration fg,
            string? name = null)
        {
            BookTeachTargetMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (!(obj is IBookTeachTargetGetter rhs)) return false;
            return ((BookTeachTargetCommon)((IBookTeachTargetGetter)this).CommonInstance()!).Equals(this, rhs);
        }

        public bool Equals(IBookTeachTargetGetter? obj)
        {
            return ((BookTeachTargetCommon)((IBookTeachTargetGetter)this).CommonInstance()!).Equals(this, obj);
        }

        public override int GetHashCode() => ((BookTeachTargetCommon)((IBookTeachTargetGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

