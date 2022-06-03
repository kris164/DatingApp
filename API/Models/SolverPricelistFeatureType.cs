using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverPricelistFeatureType
    {
        public SolverPricelistFeatureType()
        {
            SolverPricelistFeatures = new HashSet<SolverPricelistFeature>();
        }

        public int PricelistFeatureTypeId { get; set; }
        public string PricelistFeatureName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<SolverPricelistFeature> SolverPricelistFeatures { get; set; }
    }
}
