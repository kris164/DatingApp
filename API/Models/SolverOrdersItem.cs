using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverOrdersItem
    {
        public SolverOrdersItem()
        {
            SolverOrdersItemsFeatures = new HashSet<SolverOrdersItemsFeature>();
            SolverRouteBundleItems = new HashSet<SolverRouteBundleItem>();
        }

        public int SolverTaskId { get; set; }
        public int SolverOrderId { get; set; }
        public int OrderItemId { get; set; }
        public int Amount { get; set; }

        public virtual SolverOrder Solver { get; set; }
        public virtual ICollection<SolverOrdersItemsFeature> SolverOrdersItemsFeatures { get; set; }
        public virtual ICollection<SolverRouteBundleItem> SolverRouteBundleItems { get; set; }
    }
}
