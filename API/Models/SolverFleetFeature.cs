using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverFleetFeature
    {
        public int SolverTaskId { get; set; }
        public int FleetId { get; set; }
        public int FleetFeatureTypeId { get; set; }
        public double FleetFeatureValue { get; set; }

        public virtual SolverFleetFeatureType FleetFeatureType { get; set; }
        public virtual SolverFleet SolverFleet { get; set; }
    }
}
