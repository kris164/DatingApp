using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MobileTask
    {
        public int MobileTaskId { get; set; }
        public int? MobileTaskTypeId { get; set; }
        public int? MobileTaskStateId { get; set; }
        public int? DetailIndex1 { get; set; }
        public int? DetailIndex2 { get; set; }
        public int? DetailIndex3 { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? Finish { get; set; }
        public int? DriverId { get; set; }
    }
}
