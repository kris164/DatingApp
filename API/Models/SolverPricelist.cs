using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverPricelist
    {
        public SolverPricelist()
        {
            SolverFlatPricelists = new HashSet<SolverFlatPricelist>();
            SolverPerWeightPricelists = new HashSet<SolverPerWeightPricelist>();
            SolverPoiPairFlatRatePricelists = new HashSet<SolverPoiPairFlatRatePricelist>();
            SolverPois = new HashSet<SolverPoi>();
            SolverPricelistFeatures = new HashSet<SolverPricelistFeature>();
            SolverPricelistRangedPrices = new HashSet<SolverPricelistRangedPrice>();
        }

        public int SolverTaskId { get; set; }
        public int PricelistId { get; set; }
        public string Name { get; set; }
        public int? SolverCarrierId { get; set; }
        public int? SolverTruckProfileId { get; set; }
        public int PricelistTypeId { get; set; }

        public virtual SolverPricelistType PricelistType { get; set; }
        public virtual SolverCarrier Solver { get; set; }
        public virtual SolverTruckProfile SolverT { get; set; }
        public virtual ICollection<SolverFlatPricelist> SolverFlatPricelists { get; set; }
        public virtual ICollection<SolverPerWeightPricelist> SolverPerWeightPricelists { get; set; }
        public virtual ICollection<SolverPoiPairFlatRatePricelist> SolverPoiPairFlatRatePricelists { get; set; }
        public virtual ICollection<SolverPoi> SolverPois { get; set; }
        public virtual ICollection<SolverPricelistFeature> SolverPricelistFeatures { get; set; }
        public virtual ICollection<SolverPricelistRangedPrice> SolverPricelistRangedPrices { get; set; }
    }
}
