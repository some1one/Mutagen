using Loqui;
using Loqui.Generation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutagen.Bethesda.Generation
{
    public class MajorRecordModule : GenerationModule
    {
        public override async Task LoadWrapup(ObjectGeneration obj)
        {
            if (await obj.IsMajorRecord())
            {
                obj.BasicCtorPermission = CtorPermissionLevel.@protected;
            }
            await base.LoadWrapup(obj);
        }

        public override async Task GenerateInCommon(ObjectGeneration obj, FileGeneration fg, MaskTypeSet maskTypes)
        {
            if (!await obj.IsMajorRecord()) return;
            if (!maskTypes.Applicable(LoquiInterfaceType.IGetter, CommonGenerics.Class, MaskType.Normal)) return;
            //ToDo
            // Modify to getter interface after copy is refactored
            fg.AppendLine($"partial void PostDuplicate({obj.Name} obj, {obj.ObjectName} rhs, Func<FormKey> getNextFormKey, IList<({nameof(IMajorRecordCommon)} Record, FormKey OriginalFormKey)>? duplicatedRecords);");
            fg.AppendLine();

            fg.AppendLine($"public{obj.FunctionOverride()}{nameof(IMajorRecordCommon)} Duplicate({nameof(IMajorRecordCommonGetter)} item, Func<FormKey> getNextFormKey, IList<({nameof(IMajorRecordCommon)} Record, FormKey OriginalFormKey)>? duplicatedRecords)");
            using (new BraceWrapper(fg))
            {
                if (obj.Abstract)
                {
                    fg.AppendLine($"throw new {nameof(NotImplementedException)}();");
                }
                else
                {
                    fg.AppendLine($"var ret = new {obj.Name}(getNextFormKey());");
                    //ToDo
                    // Modify to getter interface after copy is refactored
                    fg.AppendLine($"ret.DeepCopyIn(({obj.ObjectName})item);");
                    fg.AppendLine("duplicatedRecords?.Add((ret, item.FormKey));");
                    fg.AppendLine($"PostDuplicate(ret, ({obj.ObjectName})item, getNextFormKey, duplicatedRecords);");
                    fg.AppendLine("return ret;");
                }
            }
            fg.AppendLine();
        }

        public override async Task GenerateInClass(ObjectGeneration obj, FileGeneration fg)
        {
            await base.GenerateInClass(obj, fg);
            if (!await obj.IsMajorRecord()) return;
            fg.AppendLine($"public {obj.Name}(FormKey formKey)");
            using (new BraceWrapper(fg))
            {
                fg.AppendLine("this.FormKey = formKey;");
                fg.AppendLine("CustomCtor();");
            }
            fg.AppendLine();

            fg.AppendLine($"public {obj.Name}(IMod mod)");
            using (new DepthWrapper(fg))
            {
                fg.AppendLine($": this(mod.{nameof(IMod.GetNextFormKey)}())");
            }
            using (new BraceWrapper(fg))
            {
            }
            fg.AppendLine();

            fg.AppendLine($"public {obj.Name}(IMod mod, string editorID)");
            using (new DepthWrapper(fg))
            {
                fg.AppendLine($": this(mod.{nameof(IMod.GetNextFormKey)}(editorID))");
            }
            using (new BraceWrapper(fg))
            {
                fg.AppendLine("this.EditorID = editorID;");
            }
            fg.AppendLine();
        }

        public override async Task GenerateInCommonMixin(ObjectGeneration obj, FileGeneration fg)
        {
            if (!await obj.IsMajorRecord()) return;
            if (!obj.IsTopClass) return;
            using (var args = new FunctionWrapper(fg,
                $"public static {nameof(IMajorRecordCommon)} {nameof(IDuplicatable.Duplicate)}"))
            {
                //ToDo
                // Modify to getter interface after copy is refactored
                args.Add($"this {obj.ObjectName} item");
                args.Add("Func<FormKey> getNextFormKey");
                args.Add($"IList<({nameof(IMajorRecordCommon)} Record, FormKey OriginalFormKey)>? duplicatedRecords = null");
            }
            using (new BraceWrapper(fg))
            {
                using (var args = new ArgsWrapper(fg,
                     $"return {obj.CommonClassInstance("item", LoquiInterfaceType.IGetter, CommonGenerics.Class, MaskType.Normal)}.{nameof(IDuplicatable.Duplicate)}"))
                {
                    args.AddPassArg("item");
                    args.AddPassArg("getNextFormKey");
                    args.AddPassArg("duplicatedRecords");
                }
            }
        }

        public static async Task<Case> HasMajorRecordsInTree(ObjectGeneration obj, bool includeBaseClass, GenericSpecification specifications = null)
        {
            if (await HasMajorRecords(obj, includeBaseClass: includeBaseClass, includeSelf: false, specifications: specifications) == Case.Yes) return Case.Yes;
            // If no, check subclasses  
            foreach (var inheritingObject in await obj.InheritingObjects())
            {
                if (await HasMajorRecordsInTree(inheritingObject, includeBaseClass: false, specifications: specifications) == Case.Yes) return Case.Yes;
            }

            return Case.No;
        }

        public static async Task<Case> HasMajorRecords(LoquiType loqui, bool includeBaseClass, GenericSpecification specifications = null)
        {
            if (loqui.TargetObjectGeneration != null)
            {
                if (await loqui.TargetObjectGeneration.IsMajorRecord()) return Case.Yes;
                return await MajorRecordModule.HasMajorRecordsInTree(loqui.TargetObjectGeneration, includeBaseClass, loqui.GenericSpecification);
            }
            else if (specifications != null)
            {
                foreach (var target in specifications.Specifications.Values)
                {
                    if (!ObjectNamedKey.TryFactory(target, out var key)) continue;
                    var specObj = loqui.ObjectGen.ProtoGen.Gen.ObjectGenerationsByObjectNameKey[key];
                    if (await specObj.IsMajorRecord()) return Case.Yes;
                    return await MajorRecordModule.HasMajorRecordsInTree(specObj, includeBaseClass);
                }
            }
            else if (loqui.RefType == LoquiType.LoquiRefType.Interface)
            {
                // ToDo  
                // Quick hack.  Real solution should use reflection to investigate the interface  
                return Case.Yes;
            }
            return Case.Maybe;
        }

        public static async Task<Case> HasMajorRecords(ObjectGeneration obj, bool includeBaseClass, bool includeSelf, GenericSpecification specifications = null)
        {
            if (obj.Name == "ListGroup") return Case.Yes;
            foreach (var field in obj.IterateFields(includeBaseClass: includeBaseClass))
            {
                if (field is LoquiType loqui)
                {
                    if (includeSelf
                        && loqui.TargetObjectGeneration != null
                        && await loqui.TargetObjectGeneration.IsMajorRecord())
                    {
                        return Case.Yes;
                    }
                    if (await HasMajorRecords(loqui, includeBaseClass, specifications) == Case.Yes) return Case.Yes;
                }
                else if (field is ContainerType cont)
                {
                    if (cont.SubTypeGeneration is LoquiType contLoqui)
                    {
                        if (await HasMajorRecords(contLoqui, includeBaseClass, specifications) == Case.Yes) return Case.Yes;
                    }
                }
                else if (field is DictType dict)
                {
                    if (dict.ValueTypeGen is LoquiType valLoqui)
                    {
                        if (await HasMajorRecords(valLoqui, includeBaseClass, specifications) == Case.Yes) return Case.Yes;
                    }
                    if (dict.KeyTypeGen is LoquiType keyLoqui)
                    {
                        if (await HasMajorRecords(keyLoqui, includeBaseClass, specifications) == Case.Yes) return Case.Yes;
                    }
                }
            }
            return Case.No;
        }

        public static async IAsyncEnumerable<ObjectGeneration> IterateMajorRecords(LoquiType loqui, bool includeBaseClass, GenericSpecification specifications = null)
        {
            if (specifications?.Specifications.Count > 0)
            {
                foreach (var target in specifications.Specifications.Values)
                {
                    if (!ObjectNamedKey.TryFactory(target, out var key)) continue;
                    var specObj = loqui.ObjectGen.ProtoGen.Gen.ObjectGenerationsByObjectNameKey[key];
                    if (await specObj.IsMajorRecord()) yield return specObj;
                    await foreach (var item in IterateMajorRecords(specObj, includeBaseClass, includeSelf: true, loqui.GenericSpecification))
                    {
                        yield return item;
                    }
                }
            }
            else if (loqui.TargetObjectGeneration != null)
            {
                if (await loqui.TargetObjectGeneration.IsMajorRecord()) yield return loqui.TargetObjectGeneration;
                await foreach (var item in IterateMajorRecords(loqui.TargetObjectGeneration, includeBaseClass, includeSelf: true, loqui.GenericSpecification))
                {
                    yield return item;
                }
            }
            else if (loqui.RefType == LoquiType.LoquiRefType.Interface)
            {
                // Must be a link interface 
                if (!LinkInterfaceModule.ObjectMappings[loqui.ObjectGen.ProtoGen.Protocol].TryGetValue(loqui.SetterInterface, out var mappings))
                {
                    throw new ArgumentException();
                }
                foreach (var obj in mappings)
                {
                    yield return obj;
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public static async IAsyncEnumerable<ObjectGeneration> IterateMajorRecords(ObjectGeneration obj, bool includeBaseClass, bool includeSelf, GenericSpecification specifications = null)
        {
            foreach (var field in obj.IterateFields(includeBaseClass: includeBaseClass))
            {
                if (field is LoquiType loqui)
                {
                    if (includeSelf
                        && loqui.TargetObjectGeneration != null
                        && await loqui.TargetObjectGeneration.IsMajorRecord())
                    {
                        yield return loqui.TargetObjectGeneration;
                    }
                    await foreach (var item in IterateMajorRecords(loqui, includeBaseClass, specifications))
                    {
                        yield return item;
                    }
                }
                else if (field is ContainerType cont)
                {
                    if (cont.SubTypeGeneration is LoquiType contLoqui)
                    {
                        await foreach (var item in IterateMajorRecords(contLoqui, includeBaseClass, specifications))
                        {
                            yield return item;
                        }
                    }
                }
                else if (field is DictType dict)
                {
                    if (dict.ValueTypeGen is LoquiType valLoqui)
                    {
                        await foreach (var item in IterateMajorRecords(valLoqui, includeBaseClass, specifications))
                        {
                            yield return item;
                        }
                    }
                    if (dict.KeyTypeGen is LoquiType keyLoqui)
                    {
                        await foreach (var item in IterateMajorRecords(keyLoqui, includeBaseClass, specifications))
                        {
                            yield return item;
                        }
                    }
                }
            }
        }
    }
}
