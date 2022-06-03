using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class AppDebugInfoObject
    {
        public int IdAppDebugInfoObject { get; set; }
        public int? AppDebugInfoId { get; set; }
        public DateTime? StartDt { get; set; }
        public DateTime? StopDt { get; set; }
        public string ObjectClass { get; set; }
        public string Info { get; set; }
    }
}
