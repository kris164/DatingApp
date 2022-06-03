using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverRouteEventBundle
    {
        public int SolverRouteId { get; set; }
        public int EventRoutePos { get; set; }
        public int BundleId { get; set; }

        public virtual SolverRouteBundle SolverRouteBundle { get; set; }
        public virtual SolverRouteEvent SolverRouteEvent { get; set; }
    }
}
