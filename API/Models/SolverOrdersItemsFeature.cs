using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverOrdersItemsFeature
    {
        public int SolverTaskId { get; set; }
        public int SolverOrderId { get; set; }
        public int OrderItemId { get; set; }
        public int FeatureTypeId { get; set; }
        public double FeatureValue { get; set; }

        public virtual SolverOrdersFeatureType FeatureType { get; set; }
        public virtual SolverOrdersItem SolverOrdersItem { get; set; }
    }
}
