using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverOrdersItemsBundleType
    {
        public SolverOrdersItemsBundleType()
        {
            SolverRouteBundles = new HashSet<SolverRouteBundle>();
        }

        public int BundleTypeId { get; set; }
        public string BundleTypeName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<SolverRouteBundle> SolverRouteBundles { get; set; }
    }
}
