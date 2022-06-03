using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverOrderServiceTime
    {
        public int SolverTaskId { get; set; }
        public int SolverOrderId { get; set; }
        public double ServiceTime { get; set; }

        public virtual SolverOrder Solver { get; set; }
    }
}
