﻿using Loqui.Generation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutagen.Generation
{
    public class MutagenFieldData
    {
        public readonly TypeGeneration SourceTypeGeneration;
        public RecordType? MarkerType { get; set; }
        public RecordType? RecordType { get; set; }
        public HashSet<RecordType> TriggeringRecordTypes { get; } = new HashSet<Mutagen.RecordType>();
        public HashSet<string> TriggeringRecordAccessors = new HashSet<string>();
        public string TriggeringRecordSetAccessor;
        public bool HasTrigger => this.TriggeringRecordAccessors.Count > 0;
        public bool Optional;
        public long? Length;
        public bool IncludeInLength;
        public bool Vestigial;
        public bool CustomBinary;
        public Dictionary<RecordType, ObjectGeneration> SubLoquiTypes = new Dictionary<RecordType, ObjectGeneration>();
        public IEnumerable<KeyValuePair<IEnumerable<RecordType>, TypeGeneration>> GenerationTypes => GetGenerationTypes();

        public MutagenFieldData(TypeGeneration source)
        {
            this.SourceTypeGeneration = source;
        }

        private IEnumerable<KeyValuePair<IEnumerable<RecordType>, TypeGeneration>> GetGenerationTypes()
        {
            yield return new KeyValuePair<IEnumerable<RecordType>, TypeGeneration>(
                this.TriggeringRecordTypes,
                this.SourceTypeGeneration);
            if (!(this.SourceTypeGeneration is LoquiType loqui)) yield break;
            foreach (var subType in this.SubLoquiTypes
                .GroupBy((g) => g.Value))
            {
                yield return new KeyValuePair<IEnumerable<RecordType>, TypeGeneration>(
                    subType.Select((s) => s.Key),
                    loqui.Spawn(subType.Key));
            }
        }
    }
}
