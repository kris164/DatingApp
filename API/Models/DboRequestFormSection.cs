using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class DboRequestFormSection
    {
        public int ArchId { get; set; }
        public DateTime ArchDt { get; set; }
        public string ArchOp { get; set; }
        public string ArchSql { get; set; }
        public string ArchHostName { get; set; }
        public int RequestFormSectionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Required { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
        public int? SectionOrder { get; set; }
        public int? RequestFormId { get; set; }
        public int? Collapsed { get; set; }
        public int? Collapsible { get; set; }
    }
}
