using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverRouteEventOrder
    {
        public int SolverRouteId { get; set; }
        public int EventRoutePos { get; set; }
        public int SolverTaskId { get; set; }
        public int SolverOrderId { get; set; }

        public virtual SolverOrder Solver { get; set; }
        public virtual SolverRouteEvent SolverRouteEvent { get; set; }
    }
}
