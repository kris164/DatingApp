using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ImportSchemaMapping
    {
        public int ImportSchemaMappingId { get; set; }
        public int ImportSchemaDefinitionId { get; set; }
        public int SourceFieldId { get; set; }
        public int ImportObjectDefinitionId { get; set; }
        public object DefaultValue { get; set; }
    }
}
