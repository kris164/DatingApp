using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverPoiPairFlatRatePricelist
    {
        public int SolverTaskId { get; set; }
        public int PricelistId { get; set; }
        public int SrcPoiId { get; set; }
        public int DstPoiId { get; set; }
        public double Price { get; set; }

        public virtual SolverPoi S { get; set; }
        public virtual SolverPoi SolverPoi { get; set; }
        public virtual SolverPricelist SolverPricelist { get; set; }
    }
}
