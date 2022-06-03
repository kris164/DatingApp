using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverFleetPosition
    {
        public int SolverTaskId { get; set; }
        public int FleetId { get; set; }
        public int SolverPoiId { get; set; }

        public virtual SolverPoi Solver { get; set; }
        public virtual SolverFleet SolverFleet { get; set; }
    }
}
