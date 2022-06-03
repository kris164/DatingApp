using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class CrReportLog
    {
        public int IdCrReportLog { get; set; }
        public string Rpt { get; set; }
        public int? IsTtx { get; set; }
        public int? SaveToFile { get; set; }
        public DateTime? Dt { get; set; }
        public int? ExecTime { get; set; }
        public string AppName { get; set; }
        public int? UserId { get; set; }
        public string FileName { get; set; }
    }
}
