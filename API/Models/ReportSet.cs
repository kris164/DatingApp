using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ReportSet
    {
        public int IdReportSet { get; set; }
        public string Code { get; set; }
        public int Active { get; set; }
        public string Description { get; set; }
    }
}
