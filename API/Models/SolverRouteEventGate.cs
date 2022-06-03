using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverRouteEventGate
    {
        public int SolverRouteId { get; set; }
        public int EventRoutePos { get; set; }
        public int SolverTaskId { get; set; }
        public long SolverPoiGateId { get; set; }
        public bool IsVirtual { get; set; }

        public virtual SolverPoiGate SolverPoiGate { get; set; }
        public virtual SolverRouteEvent SolverRouteEvent { get; set; }
    }
}
