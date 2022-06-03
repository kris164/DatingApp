using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverPoiGateTimeWindow
    {
        public int SolverTaskId { get; set; }
        public long SolverPoiGateId { get; set; }
        public DateTime? WindowStart { get; set; }
        public DateTime? WindowEnd { get; set; }
        public bool IsVirtual { get; set; }
        public bool? IsValid { get; set; }

        public virtual SolverPoiGate SolverPoiGate { get; set; }
    }
}
