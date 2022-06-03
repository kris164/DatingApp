using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverEventCostType
    {
        public SolverEventCostType()
        {
            SolverRouteEventCosts = new HashSet<SolverRouteEventCost>();
        }

        public int CostTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<SolverRouteEventCost> SolverRouteEventCosts { get; set; }
    }
}
