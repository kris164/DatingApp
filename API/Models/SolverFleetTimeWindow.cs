using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverFleetTimeWindow
    {
        public int SolverTaskId { get; set; }
        public int FleetId { get; set; }
        public DateTime? WindowStart { get; set; }
        public DateTime? WindowEnd { get; set; }

        public virtual SolverFleet SolverFleet { get; set; }
    }
}
