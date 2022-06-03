using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ReportSetPo
    {
        public int IdReportSetPos { get; set; }
        public int ReportSetId { get; set; }
        public int Position { get; set; }
        public string ReportName { get; set; }
        public int SetPrinter { get; set; }
    }
}
