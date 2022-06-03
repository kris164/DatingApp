using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class OptimizationFtlLog
    {
        public int OptimizationFtlLogId { get; set; }
        public int SessionId { get; set; }
        public DateTime? Date { get; set; }
        public string Mode { get; set; }
        public string Step { get; set; }
        public string Info { get; set; }
    }
}
