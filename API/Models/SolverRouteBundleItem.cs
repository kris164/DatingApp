using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverRouteBundleItem
    {
        public int SolverRouteId { get; set; }
        public int BundleId { get; set; }
        public int SolverTaskId { get; set; }
        public int SolverOrderId { get; set; }
        public int OrderItemId { get; set; }
        public int Amount { get; set; }

        public virtual SolverOrdersItem SolverOrdersItem { get; set; }
        public virtual SolverRouteBundle SolverRouteBundle { get; set; }
    }
}
