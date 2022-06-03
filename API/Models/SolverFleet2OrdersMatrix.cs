using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverFleet2OrdersMatrix
    {
        public SolverFleet2OrdersMatrix()
        {
            SolverFleet2OrdersMatricesValue = new HashSet<SolverFleet2OrdersMatrixValue>();
        }

        public int SolverTaskId { get; set; }
        public int MatrixId { get; set; }
        public int MatrixRank { get; set; }

        public virtual ICollection<SolverFleet2OrdersMatrixValue> SolverFleet2OrdersMatricesValue { get; set; }
    }
}
