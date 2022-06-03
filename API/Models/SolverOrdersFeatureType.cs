using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverOrdersFeatureType
    {
        public SolverOrdersFeatureType()
        {
            SolverOrdersFeatures = new HashSet<SolverOrdersFeature>();
            SolverOrdersItemsFeatures = new HashSet<SolverOrdersItemsFeature>();
        }

        public int FeatureTypeId { get; set; }
        public string FeatureTypeName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<SolverOrdersFeature> SolverOrdersFeatures { get; set; }
        public virtual ICollection<SolverOrdersItemsFeature> SolverOrdersItemsFeatures { get; set; }
    }
}
