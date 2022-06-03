using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ReportLabel
    {
        public int ReportLabelId { get; set; }
        public string ReportSlot { get; set; }
        public string ReportInfo { get; set; }
        public string LabelName { get; set; }
        public string DefaultLabelText { get; set; }
        public int? System { get; set; }
        public int? CreateLanguageId { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
