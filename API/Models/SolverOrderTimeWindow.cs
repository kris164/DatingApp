using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverOrderTimeWindow
    {
        public int SolverTaskId { get; set; }
        public int SolverOrderId { get; set; }
        public DateTime? WindowStart { get; set; }
        public DateTime? WindowEnd { get; set; }
        public int TypeId { get; set; }

        public virtual SolverOrder Solver { get; set; }
        public virtual SolverTimeWindowType Type { get; set; }
    }
}
