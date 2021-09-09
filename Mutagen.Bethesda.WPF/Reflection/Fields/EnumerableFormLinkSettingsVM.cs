using Loqui;
using Mutagen.Bethesda;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Cache;
using Mutagen.Bethesda.Plugins.Records.Internals;
using Mutagen.Bethesda.WPF.Plugins;
using Newtonsoft.Json.Linq;
using Noggog;
using Noggog.WPF;
using ReactiveUI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using System.Text.Json;

namespace Mutagen.Bethesda.WPF.Reflection.Fields
{
    public class EnumerableFormLinkSettingsVM : SettingsNodeVM
    {
        public ObservableCollection<FormKey> Values { get; } = new();

        private FormKey[] _defaultVal;
        private readonly IObservable<ILinkCache?> _linkCacheObs;
        private readonly ObservableAsPropertyHelper<ILinkCache?> _LinkCache;
        private readonly string _typeName;
        public ILinkCache? LinkCache => _LinkCache.Value;

        public IEnumerable<Type> ScopedTypes { get; private set; } = Enumerable.Empty<Type>();

        public EnumerableFormLinkSettingsVM(
            IObservable<ILinkCache?> linkCache,
            FieldMeta fieldMeta,
            string typeName,
            IEnumerable<FormKey> defaultVal)
            : base(fieldMeta)
        {
            _defaultVal = defaultVal.ToArray();
            _linkCacheObs = linkCache;
            _typeName = typeName;
            _LinkCache = linkCache
                .ToGuiProperty(this, nameof(LinkCache), default(ILinkCache?));
        }

        public static SettingsNodeVM Factory(ReflectionSettingsParameters param, FieldMeta fieldMeta, string typeName, object? defaultVal)
        {
            var defaultKeys = new List<FormKey>();
            if (defaultVal is IEnumerable e)
            {
                var targetType = e.GetType().GenericTypeArguments[0];
                var getter = targetType.GetPublicProperties().FirstOrDefault(m => m.Name == "FormKey")!;
                foreach (var item in e)
                {
                    defaultKeys.Add(FormKey.Factory(getter.GetValue(item)!.ToString()));
                }
            }
            return new EnumerableFormLinkSettingsVM(
                param.LinkCache,
                fieldMeta: fieldMeta,
                typeName: typeName,
                defaultKeys);
        }

        public override void Import(JsonElement property, Action<string> logger)
        {
            Values.Clear();
            foreach (var elem in property.EnumerateArray())
            {
                if (FormKey.TryFactory(elem.GetString(), out var formKey))
                {
                    Values.Add(formKey);
                }
                else
                {
                    Values.Add(FormKey.Null);
                }
            }
        }

        public override void Persist(JObject obj, Action<string> logger)
        {
            obj[Meta.DiskName] = new JArray(Values
                .Select(x =>
                {
                    if (x.IsNull)
                    {
                        return string.Empty;
                    }
                    else
                    {
                        return x.ToString();
                    }
                }).ToArray());
        }

        public override SettingsNodeVM Duplicate()
        {
            return new EnumerableFormLinkSettingsVM(
                linkCache: _linkCacheObs,
                typeName: _typeName, 
                fieldMeta: Meta, 
                defaultVal: _defaultVal);
        }

        public override void WrapUp()
        {
            _defaultVal = _defaultVal.Select(x => FormKeySettingsVM.StripOrigin(x)).ToArray();
            Values.SetTo(_defaultVal);

            if (LoquiRegistration.TryGetRegisterByFullName(_typeName, out var regis))
            {
                ScopedTypes = regis.GetterType.AsEnumerable();
            }
            else if (LinkInterfaceMapping.TryGetByFullName(_typeName, out var interfType))
            {
                ScopedTypes = interfType.AsEnumerable();
            }
            else
            {
                throw new ArgumentException($"Can't create a formlink control for type: {_typeName}");
            }
        }
    }
}
