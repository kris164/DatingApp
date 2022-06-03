using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverCarrier
    {
        public SolverCarrier()
        {
            SolverFleets = new HashSet<SolverFleet>();
            SolverPerPoiFlatRates = new HashSet<SolverPerPoiFlatRate>();
            SolverPricelists = new HashSet<SolverPricelist>();
            SolverRoutes = new HashSet<SolverRoute>();
        }

        public int SolverTaskId { get; set; }
        public int SolverCarrierId { get; set; }
        public string CarrierCode { get; set; }
        public double? Share { get; set; }
        public int? VehiclesCount { get; set; }

        public virtual ICollection<SolverFleet> SolverFleets { get; set; }
        public virtual ICollection<SolverPerPoiFlatRate> SolverPerPoiFlatRates { get; set; }
        public virtual ICollection<SolverPricelist> SolverPricelists { get; set; }
        public virtual ICollection<SolverRoute> SolverRoutes { get; set; }
    }
}
