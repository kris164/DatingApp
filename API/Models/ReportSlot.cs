using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ReportSlot
    {
        public int ReportSlotId { get; set; }
        public string ReportSlot1 { get; set; }
        public int? ApplicationId { get; set; }
        public int? ApplicationModuleId { get; set; }
        public int? DictionaryId { get; set; }
        public string DefaultText { get; set; }
    }
}
