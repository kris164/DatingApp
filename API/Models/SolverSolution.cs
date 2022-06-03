using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverSolution
    {
        public SolverSolution()
        {
            SolverRoutes = new HashSet<SolverRoute>();
        }

        public int SolverSolutionId { get; set; }
        public int SolverTaskId { get; set; }

        public virtual SolverTask SolverTask { get; set; }
        public virtual ICollection<SolverRoute> SolverRoutes { get; set; }
    }
}
