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
    public partial class Placement :
        IPlacement,
        ILoquiObjectSetter<Placement>,
        IEquatable<IPlacementGetter>
    {
        #region Ctor
        public Placement()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region Position
        public P3Float Position { get; set; } = default;
        #endregion
        #region Rotation
        public P3Float Rotation { get; set; } = default;
        #endregion

        #region To String

        public void ToString(
            FileGeneration fg,
            string? name = null)
        {
            PlacementMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (!(obj is IPlacementGetter rhs)) return false;
            return ((PlacementCommon)((IPlacementGetter)this).CommonInstance()!).Equals(this, rhs);
        }

        public bool Equals(IPlacementGetter? obj)
        {
            return ((PlacementCommon)((IPlacementGetter)this).CommonInstance()!).Equals(this, obj);
        }

        public override int GetHashCode() => ((PlacementCommon)((IPlacementGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public class Mask<TItem> :
            IMask<TItem>,
            IEquatable<Mask<TItem>>
        {
            #region Ctors
            public Mask(TItem initialValue)
            {
                this.Position = initialValue;
                this.Rotation = initialValue;
            }

            public Mask(
                TItem Position,
                TItem Rotation)
            {
                this.Position = Position;
                this.Rotation = Rotation;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem Position;
            public TItem Rotation;
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
                if (!object.Equals(this.Position, rhs.Position)) return false;
                if (!object.Equals(this.Rotation, rhs.Rotation)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.Position);
                hash.Add(this.Rotation);
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public bool All(Func<TItem, bool> eval)
            {
                if (!eval(this.Position)) return false;
                if (!eval(this.Rotation)) return false;
                return true;
            }
            #endregion

            #region Any
            public bool Any(Func<TItem, bool> eval)
            {
                if (eval(this.Position)) return true;
                if (eval(this.Rotation)) return true;
                return false;
            }
            #endregion

            #region Translate
            public Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new Placement.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                obj.Position = eval(this.Position);
                obj.Rotation = eval(this.Rotation);
            }
            #endregion

            #region To String
            public override string ToString()
            {
                return ToString(printMask: null);
            }

            public string ToString(Placement.Mask<bool>? printMask = null)
            {
                var fg = new FileGeneration();
                ToString(fg, printMask);
                return fg.ToString();
            }

            public void ToString(FileGeneration fg, Placement.Mask<bool>? printMask = null)
            {
                fg.AppendLine($"{nameof(Placement.Mask<TItem>)} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
                    if (printMask?.Position ?? true)
                    {
                        fg.AppendItem(Position, "Position");
                    }
                    if (printMask?.Rotation ?? true)
                    {
                        fg.AppendItem(Rotation, "Rotation");
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
            public Exception? Position;
            public Exception? Rotation;
            #endregion

            #region IErrorMask
            public object? GetNthMask(int index)
            {
                Placement_FieldIndex enu = (Placement_FieldIndex)index;
                switch (enu)
                {
                    case Placement_FieldIndex.Position:
                        return Position;
                    case Placement_FieldIndex.Rotation:
                        return Rotation;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthException(int index, Exception ex)
            {
                Placement_FieldIndex enu = (Placement_FieldIndex)index;
                switch (enu)
                {
                    case Placement_FieldIndex.Position:
                        this.Position = ex;
                        break;
                    case Placement_FieldIndex.Rotation:
                        this.Rotation = ex;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthMask(int index, object obj)
            {
                Placement_FieldIndex enu = (Placement_FieldIndex)index;
                switch (enu)
                {
                    case Placement_FieldIndex.Position:
                        this.Position = (Exception?)obj;
                        break;
                    case Placement_FieldIndex.Rotation:
                        this.Rotation = (Exception?)obj;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public bool IsInError()
            {
                if (Overall != null) return true;
                if (Position != null) return true;
                if (Rotation != null) return true;
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
                fg.AppendItem(Position, "Position");
                fg.AppendItem(Rotation, "Rotation");
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.Position = this.Position.Combine(rhs.Position);
                ret.Rotation = this.Rotation.Combine(rhs.Rotation);
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
            public bool Position;
            public bool Rotation;
            #endregion

            #region Ctors
            public TranslationMask(bool defaultOn)
            {
                this.DefaultOn = defaultOn;
                this.Position = defaultOn;
                this.Rotation = defaultOn;
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
                ret.Add((Position, null));
                ret.Add((Rotation, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn);
            }

        }
        #endregion

        #region Mutagen
        public static readonly RecordType GrupRecordType = Placement_Registration.TriggeringRecordType;
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected object BinaryWriteTranslator => PlacementBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((PlacementBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }
        #region Binary Create
        public static Placement CreateFromBinary(
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var ret = new Placement();
            ((PlacementSetterCommon)((IPlacementGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                recordTypeConverter: recordTypeConverter);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out Placement item,
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
            ((PlacementSetterCommon)((IPlacementGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static Placement GetNew()
        {
            return new Placement();
        }

    }
    #endregion

    #region Interface
    public partial interface IPlacement :
        IPlacementGetter,
        IPositionRotation,
        ILoquiObjectSetter<IPlacement>
    {
        new P3Float Position { get; set; }
        new P3Float Rotation { get; set; }
    }

    public partial interface IPlacementGetter :
        ILoquiObject,
        IPositionRotationGetter,
        ILoquiObject<IPlacementGetter>,
        IBinaryItem
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object? CommonSetterInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonSetterTranslationInstance();
        static ILoquiRegistration Registration => Placement_Registration.Instance;
        P3Float Position { get; }
        P3Float Rotation { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class PlacementMixIn
    {
        public static void Clear(this IPlacement item)
        {
            ((PlacementSetterCommon)((IPlacementGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static Placement.Mask<bool> GetEqualsMask(
            this IPlacementGetter item,
            IPlacementGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((PlacementCommon)((IPlacementGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string ToString(
            this IPlacementGetter item,
            string? name = null,
            Placement.Mask<bool>? printMask = null)
        {
            return ((PlacementCommon)((IPlacementGetter)item).CommonInstance()!).ToString(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void ToString(
            this IPlacementGetter item,
            FileGeneration fg,
            string? name = null,
            Placement.Mask<bool>? printMask = null)
        {
            ((PlacementCommon)((IPlacementGetter)item).CommonInstance()!).ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IPlacementGetter item,
            IPlacementGetter rhs)
        {
            return ((PlacementCommon)((IPlacementGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs);
        }

        public static void DeepCopyIn(
            this IPlacement lhs,
            IPlacementGetter rhs)
        {
            ((PlacementSetterTranslationCommon)((IPlacementGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: default,
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IPlacement lhs,
            IPlacementGetter rhs,
            Placement.TranslationMask? copyMask = null)
        {
            ((PlacementSetterTranslationCommon)((IPlacementGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IPlacement lhs,
            IPlacementGetter rhs,
            out Placement.ErrorMask errorMask,
            Placement.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((PlacementSetterTranslationCommon)((IPlacementGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = Placement.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IPlacement lhs,
            IPlacementGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((PlacementSetterTranslationCommon)((IPlacementGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static Placement DeepCopy(
            this IPlacementGetter item,
            Placement.TranslationMask? copyMask = null)
        {
            return ((PlacementSetterTranslationCommon)((IPlacementGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static Placement DeepCopy(
            this IPlacementGetter item,
            out Placement.ErrorMask errorMask,
            Placement.TranslationMask? copyMask = null)
        {
            return ((PlacementSetterTranslationCommon)((IPlacementGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static Placement DeepCopy(
            this IPlacementGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((PlacementSetterTranslationCommon)((IPlacementGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IPlacement item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((PlacementSetterCommon)((IPlacementGetter)item).CommonSetterInstance()!).CopyInFromBinary(
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
    public enum Placement_FieldIndex
    {
        Position = 0,
        Rotation = 1,
    }
    #endregion

    #region Registration
    public partial class Placement_Registration : ILoquiRegistration
    {
        public static readonly Placement_Registration Instance = new Placement_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Skyrim.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Skyrim.ProtocolKey,
            msgID: 479,
            version: 0);

        public const string GUID = "4b94975c-9eee-4f58-a4da-edda94e7e252";

        public const ushort AdditionalFieldCount = 2;

        public const ushort FieldCount = 2;

        public static readonly Type MaskType = typeof(Placement.Mask<>);

        public static readonly Type ErrorMaskType = typeof(Placement.ErrorMask);

        public static readonly Type ClassType = typeof(Placement);

        public static readonly Type GetterType = typeof(IPlacementGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IPlacement);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Skyrim.Placement";

        public const string Name = "Placement";

        public const string Namespace = "Mutagen.Bethesda.Skyrim";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly RecordType TriggeringRecordType = RecordTypes.DATA;
        public static readonly Type BinaryWriteTranslation = typeof(PlacementBinaryWriteTranslation);
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
    public partial class PlacementSetterCommon
    {
        public static readonly PlacementSetterCommon Instance = new PlacementSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IPlacement item)
        {
            ClearPartial();
            item.Position = default;
            item.Rotation = default;
        }
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IPlacement item,
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
                fillStructs: PlacementBinaryCreateTranslation.FillBinaryStructs);
        }
        
        #endregion
        
    }
    public partial class PlacementCommon
    {
        public static readonly PlacementCommon Instance = new PlacementCommon();

        public Placement.Mask<bool> GetEqualsMask(
            IPlacementGetter item,
            IPlacementGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new Placement.Mask<bool>(false);
            ((PlacementCommon)((IPlacementGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IPlacementGetter item,
            IPlacementGetter rhs,
            Placement.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
            ret.Position = item.Position.Equals(rhs.Position);
            ret.Rotation = item.Rotation.Equals(rhs.Rotation);
        }
        
        public string ToString(
            IPlacementGetter item,
            string? name = null,
            Placement.Mask<bool>? printMask = null)
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
            IPlacementGetter item,
            FileGeneration fg,
            string? name = null,
            Placement.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                fg.AppendLine($"Placement =>");
            }
            else
            {
                fg.AppendLine($"{name} (Placement) =>");
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
            IPlacementGetter item,
            FileGeneration fg,
            Placement.Mask<bool>? printMask = null)
        {
            if (printMask?.Position ?? true)
            {
                fg.AppendItem(item.Position, "Position");
            }
            if (printMask?.Rotation ?? true)
            {
                fg.AppendItem(item.Rotation, "Rotation");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IPlacementGetter? lhs,
            IPlacementGetter? rhs)
        {
            if (lhs == null && rhs == null) return false;
            if (lhs == null || rhs == null) return false;
            if (!lhs.Position.Equals(rhs.Position)) return false;
            if (!lhs.Rotation.Equals(rhs.Rotation)) return false;
            return true;
        }
        
        public virtual int GetHashCode(IPlacementGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.Position);
            hash.Add(item.Rotation);
            return hash.ToHashCode();
        }
        
        #endregion
        
        
        public object GetNew()
        {
            return Placement.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<FormKey> GetLinkFormKeys(IPlacementGetter obj)
        {
            yield break;
        }
        
        public void RemapLinks(IPlacementGetter obj, IReadOnlyDictionary<FormKey, FormKey> mapping) => throw new NotImplementedException();
        #endregion
        
    }
    public partial class PlacementSetterTranslationCommon
    {
        public static readonly PlacementSetterTranslationCommon Instance = new PlacementSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IPlacement item,
            IPlacementGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            if ((copyMask?.GetShouldTranslate((int)Placement_FieldIndex.Position) ?? true))
            {
                item.Position = rhs.Position;
            }
            if ((copyMask?.GetShouldTranslate((int)Placement_FieldIndex.Rotation) ?? true))
            {
                item.Rotation = rhs.Rotation;
            }
        }
        
        #endregion
        
        public Placement DeepCopy(
            IPlacementGetter item,
            Placement.TranslationMask? copyMask = null)
        {
            Placement ret = (Placement)((PlacementCommon)((IPlacementGetter)item).CommonInstance()!).GetNew();
            ((PlacementSetterTranslationCommon)((IPlacementGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public Placement DeepCopy(
            IPlacementGetter item,
            out Placement.ErrorMask errorMask,
            Placement.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            Placement ret = (Placement)((PlacementCommon)((IPlacementGetter)item).CommonInstance()!).GetNew();
            ((PlacementSetterTranslationCommon)((IPlacementGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = Placement.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public Placement DeepCopy(
            IPlacementGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            Placement ret = (Placement)((PlacementCommon)((IPlacementGetter)item).CommonInstance()!).GetNew();
            ((PlacementSetterTranslationCommon)((IPlacementGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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
    public partial class Placement
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => Placement_Registration.Instance;
        public static Placement_Registration Registration => Placement_Registration.Instance;
        [DebuggerStepThrough]
        protected object CommonInstance() => PlacementCommon.Instance;
        [DebuggerStepThrough]
        protected object CommonSetterInstance()
        {
            return PlacementSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected object CommonSetterTranslationInstance() => PlacementSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IPlacementGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object IPlacementGetter.CommonSetterInstance() => this.CommonSetterInstance();
        [DebuggerStepThrough]
        object IPlacementGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class PlacementBinaryWriteTranslation : IBinaryWriteTranslator
    {
        public readonly static PlacementBinaryWriteTranslation Instance = new PlacementBinaryWriteTranslation();

        public static void WriteEmbedded(
            IPlacementGetter item,
            MutagenWriter writer)
        {
            Mutagen.Bethesda.Binary.P3FloatBinaryTranslation.Instance.Write(
                writer: writer,
                item: item.Position);
            Mutagen.Bethesda.Binary.P3FloatBinaryTranslation.Instance.Write(
                writer: writer,
                item: item.Rotation);
        }

        public void Write(
            MutagenWriter writer,
            IPlacementGetter item,
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
                item: (IPlacementGetter)item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

    }

    public partial class PlacementBinaryCreateTranslation
    {
        public readonly static PlacementBinaryCreateTranslation Instance = new PlacementBinaryCreateTranslation();

        public static void FillBinaryStructs(
            IPlacement item,
            MutagenFrame frame)
        {
            item.Position = Mutagen.Bethesda.Binary.P3FloatBinaryTranslation.Instance.Parse(frame: frame);
            item.Rotation = Mutagen.Bethesda.Binary.P3FloatBinaryTranslation.Instance.Parse(frame: frame);
        }

    }

}
namespace Mutagen.Bethesda.Skyrim
{
    #region Binary Write Mixins
    public static class PlacementBinaryTranslationMixIn
    {
        public static void WriteToBinary(
            this IPlacementGetter item,
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((PlacementBinaryWriteTranslation)item.BinaryWriteTranslator).Write(
                item: item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

    }
    #endregion


}
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class PlacementBinaryOverlay :
        BinaryOverlay,
        IPlacementGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => Placement_Registration.Instance;
        public static Placement_Registration Registration => Placement_Registration.Instance;
        [DebuggerStepThrough]
        protected object CommonInstance() => PlacementCommon.Instance;
        [DebuggerStepThrough]
        protected object CommonSetterTranslationInstance() => PlacementSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IPlacementGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object? IPlacementGetter.CommonSetterInstance() => null;
        [DebuggerStepThrough]
        object IPlacementGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected object BinaryWriteTranslator => PlacementBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((PlacementBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

        public P3Float Position => P3FloatBinaryTranslation.Read(_data.Slice(0x0, 0xC));
        public P3Float Rotation => P3FloatBinaryTranslation.Read(_data.Slice(0xC, 0xC));
        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected PlacementBinaryOverlay(
            ReadOnlyMemorySlice<byte> bytes,
            BinaryOverlayFactoryPackage package)
            : base(
                bytes: bytes,
                package: package)
        {
            this.CustomCtor();
        }

        public static PlacementBinaryOverlay PlacementFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var ret = new PlacementBinaryOverlay(
                bytes: HeaderTranslation.ExtractSubrecordMemory(stream.RemainingMemory, package.MetaData.Constants),
                package: package);
            var finalPos = checked((int)(stream.Position + stream.GetSubrecord().TotalLength));
            int offset = stream.Position + package.MetaData.Constants.SubConstants.TypeAndLengthLength;
            stream.Position += 0x18 + package.MetaData.Constants.SubConstants.HeaderLength;
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static PlacementBinaryOverlay PlacementFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            RecordTypeConverter? recordTypeConverter = null)
        {
            return PlacementFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                recordTypeConverter: recordTypeConverter);
        }

        #region To String

        public void ToString(
            FileGeneration fg,
            string? name = null)
        {
            PlacementMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (!(obj is IPlacementGetter rhs)) return false;
            return ((PlacementCommon)((IPlacementGetter)this).CommonInstance()!).Equals(this, rhs);
        }

        public bool Equals(IPlacementGetter? obj)
        {
            return ((PlacementCommon)((IPlacementGetter)this).CommonInstance()!).Equals(this, obj);
        }

        public override int GetHashCode() => ((PlacementCommon)((IPlacementGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

