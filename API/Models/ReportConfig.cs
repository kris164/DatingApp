using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ReportConfig
    {
        public int ReportConfigId { get; set; }
        public string AppName { get; set; }
        public string PrintOutSlot { get; set; }
        public string PrintOutRemarks { get; set; }
        public string Location { get; set; }
        public string Department { get; set; }
        public int? UserId { get; set; }
        public string Language { get; set; }
        public string FormName { get; set; }
        public string PrinterName { get; set; }
        public int? Direction { get; set; }
    }
}
