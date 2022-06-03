using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ImportSchemaDefinition
    {
        public int ImportSchemaDefinitionId { get; set; }
        public int ImportObjectId { get; set; }
        public int ImportFileTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Header { get; set; }
        public int? HeaderLineCount { get; set; }
        public int? Footer { get; set; }
        public int? FooterLineCount { get; set; }
        public string ImportDirectory { get; set; }
        public string ImportFile { get; set; }
        public int? UpdateRow { get; set; }
        public int? Archive { get; set; }
        public string ArchiveDirectory { get; set; }
        public int? ArchiveDatePrefix { get; set; }
        public string PostImportProcedure { get; set; }
        public int? UserInterface { get; set; }
    }
}
