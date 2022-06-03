using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverFleet
    {
        public SolverFleet()
        {
            SolverFleet2OrdersMatricesValue = new HashSet<SolverFleet2OrdersMatrixValue>();
            SolverFleetFeatures = new HashSet<SolverFleetFeature>();
            SolverRoutes = new HashSet<SolverRoute>();
        }

        public int SolverTaskId { get; set; }
        public int SolverTruckProfileId { get; set; }
        public int? SolverCarrierId { get; set; }
        public int? VehicleId { get; set; }
        public int Count { get; set; }
        public int? AssignedPoiId { get; set; }
        public int FleetId { get; set; }

        public virtual SolverCarrier Solver { get; set; }
        public virtual SolverPoi SolverPoi { get; set; }
        public virtual SolverTruckProfile SolverT { get; set; }
        public virtual SolverFleetPosition SolverFleetPosition { get; set; }
        public virtual SolverFleetTimeWindow SolverFleetTimeWindow { get; set; }
        public virtual ICollection<SolverFleet2OrdersMatrixValue> SolverFleet2OrdersMatricesValue { get; set; }
        public virtual ICollection<SolverFleetFeature> SolverFleetFeatures { get; set; }
        public virtual ICollection<SolverRoute> SolverRoutes { get; set; }
    }
}
