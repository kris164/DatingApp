using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverFlatPricelist
    {
        public int SolverTaskId { get; set; }
        public int PricelistId { get; set; }
        public string ItemName { get; set; }
        public double Price { get; set; }

        public virtual SolverPricelist SolverPricelist { get; set; }
    }
}
