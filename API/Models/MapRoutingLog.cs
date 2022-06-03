using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MapRoutingLog
    {
        public int MapRoutingLogId { get; set; }
        public int? ObjId { get; set; }
        public int? RecId { get; set; }
        public DateTime? ErrorDate { get; set; }
        public int? ErrorId { get; set; }
        public string ErrorMsg { get; set; }
    }
}
