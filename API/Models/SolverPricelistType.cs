using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverPricelistType
    {
        public SolverPricelistType()
        {
            SolverPricelists = new HashSet<SolverPricelist>();
        }

        public int PricelistTypeId { get; set; }
        public string PricelistTypeName { get; set; }

        public virtual ICollection<SolverPricelist> SolverPricelists { get; set; }
    }
}
