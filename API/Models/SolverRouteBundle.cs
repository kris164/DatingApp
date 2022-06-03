using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverRouteBundle
    {
        public SolverRouteBundle()
        {
            SolverRouteBundleItems = new HashSet<SolverRouteBundleItem>();
            SolverRouteEventBundles = new HashSet<SolverRouteEventBundle>();
        }

        public int SolverRouteId { get; set; }
        public int BundleId { get; set; }
        public int BundleTypeId { get; set; }

        public virtual SolverOrdersItemsBundleType BundleType { get; set; }
        public virtual SolverRoute SolverRoute { get; set; }
        public virtual ICollection<SolverRouteBundleItem> SolverRouteBundleItems { get; set; }
        public virtual ICollection<SolverRouteEventBundle> SolverRouteEventBundles { get; set; }
    }
}
