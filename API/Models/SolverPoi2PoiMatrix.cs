using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverPoi2PoiMatrix
    {
        public SolverPoi2PoiMatrix()
        {
            SolverPoi2PoiMatricesValue = new HashSet<SolverPoi2PoiMatrixValue>();
        }

        public int SolverTaskId { get; set; }
        public int MatrixId { get; set; }
        public int MatrixTypeId { get; set; }

        public virtual SolverPoi2PoiMatrixType MatrixType { get; set; }
        public virtual ICollection<SolverPoi2PoiMatrixValue> SolverPoi2PoiMatricesValue { get; set; }
    }
}
