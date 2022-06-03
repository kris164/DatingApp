using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverRouteEventCost
    {
        public int SolverRouteId { get; set; }
        public int EventRoutePos { get; set; }
        public int CostTypeId { get; set; }
        public double CostValue { get; set; }

        public virtual SolverEventCostType CostType { get; set; }
        public virtual SolverRouteEvent SolverRouteEvent { get; set; }
    }
}
