using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverPricelistRangedPrice
    {
        public int SolverTaskId { get; set; }
        public int PricelistId { get; set; }
        public double LowerBound { get; set; }
        public double? UpperBound { get; set; }
        public double Price { get; set; }

        public virtual SolverPricelist SolverPricelist { get; set; }
    }
}
