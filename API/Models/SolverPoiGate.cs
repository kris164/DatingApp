using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverPoiGate
    {
        public SolverPoiGate()
        {
            SolverRouteEventGates = new HashSet<SolverRouteEventGate>();
        }

        public int SolverTaskId { get; set; }
        public bool IsVirtual { get; set; }
        public long SolverPoiGateId { get; set; }
        public int SolverPoiId { get; set; }

        public virtual SolverPoi Solver { get; set; }
        public virtual ICollection<SolverRouteEventGate> SolverRouteEventGates { get; set; }
    }
}
