using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class AppDebugInfo
    {
        public int IdAppDebugInfo { get; set; }
        public DateTime? StartDt { get; set; }
        public DateTime? StopDt { get; set; }
        public int? UserId { get; set; }
        public string AppName { get; set; }
        public string AppVer { get; set; }
        public string StationName { get; set; }
        public string StationIp { get; set; }
    }
}
