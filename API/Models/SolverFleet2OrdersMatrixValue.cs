using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverFleet2OrdersMatrixValue
    {
        public int SolverTaskId { get; set; }
        public int MatrixId { get; set; }
        public int FleetId { get; set; }
        public int SolverOrderId { get; set; }
        public double Value { get; set; }

        public virtual SolverOrder Solver { get; set; }
        public virtual SolverFleet SolverFleet { get; set; }
        public virtual SolverFleet2OrdersMatrix SolverFleet2OrdersMatrix { get; set; }
    }
}
