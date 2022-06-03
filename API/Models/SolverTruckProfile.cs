using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverTruckProfile
    {
        public SolverTruckProfile()
        {
            SolverFleets = new HashSet<SolverFleet>();
            SolverPricelists = new HashSet<SolverPricelist>();
            SolverRoutes = new HashSet<SolverRoute>();
        }

        public int SolverTruckProfileId { get; set; }
        public int SolverTaskId { get; set; }
        public int ExtProfileId { get; set; }
        public double? MaxWeight { get; set; }
        public double? MaxVolume { get; set; }
        public double? MaxNumber { get; set; }
        public double? MaxVehicleNumber { get; set; }
        public string EquipmentName { get; set; }
        public double? CostPerKm { get; set; }

        public virtual ICollection<SolverFleet> SolverFleets { get; set; }
        public virtual ICollection<SolverPricelist> SolverPricelists { get; set; }
        public virtual ICollection<SolverRoute> SolverRoutes { get; set; }
    }
}
