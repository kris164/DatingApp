using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class OptiEtaDriver
    {
        public int Idx { get; set; }
        public int? SessionId { get; set; }
        public string Step { get; set; }
        public int? DriverId { get; set; }
        public DateTime? Dt { get; set; }
        public string Statistics { get; set; }
    }
}
