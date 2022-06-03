using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverPerPoiFlatRate
    {
        public int SolverTaskId { get; set; }
        public int SolverCarrierId { get; set; }
        public int SolverPoiId { get; set; }
        public double FlatRate { get; set; }
        public double Distance { get; set; }

        public virtual SolverCarrier Solver { get; set; }
        public virtual SolverPoi SolverNavigation { get; set; }
    }
}
