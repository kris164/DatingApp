using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Timeline
    {
        public int Timelineid { get; set; }
        public string Activity { get; set; }
        public DateTime? Activitystart { get; set; }
        public DateTime? Activitystop { get; set; }
        public int? Userid { get; set; }
        public string Host { get; set; }
        public int? Operationtype { get; set; }
    }
}
