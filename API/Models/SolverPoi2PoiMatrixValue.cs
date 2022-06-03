using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverPoi2PoiMatrixValue
    {
        public int SolverTaskId { get; set; }
        public int MatrixId { get; set; }
        public int SrcPoiId { get; set; }
        public int DstPoiId { get; set; }
        public double Value { get; set; }

        public virtual SolverPoi S { get; set; }
        public virtual SolverPoi SolverPoi { get; set; }
        public virtual SolverPoi2PoiMatrix SolverPoi2PoiMatrix { get; set; }
    }
}
