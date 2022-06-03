using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverPricelistFeature
    {
        public int SolverTaskId { get; set; }
        public int PricelistId { get; set; }
        public int PricelistFeatureTypeId { get; set; }
        public double PricelistFeatureValue { get; set; }

        public virtual SolverPricelistFeatureType PricelistFeatureType { get; set; }
        public virtual SolverPricelist SolverPricelist { get; set; }
    }
}
