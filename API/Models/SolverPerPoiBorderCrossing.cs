using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverPerPoiBorderCrossing
    {
        public int SolverTaskId { get; set; }
        public int SolverPoiId { get; set; }
        public int SolverBorderCrossingPoiId { get; set; }

        public virtual SolverPoi Solver { get; set; }
        public virtual SolverPoi SolverNavigation { get; set; }
    }
}
