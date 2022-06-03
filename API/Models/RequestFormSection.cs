using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RequestFormSection
    {
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
