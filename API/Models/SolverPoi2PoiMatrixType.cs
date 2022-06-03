using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverPoi2PoiMatrixType
    {
        public SolverPoi2PoiMatrixType()
        {
            SolverPoi2PoiMatrices = new HashSet<SolverPoi2PoiMatrix>();
        }

        public int MatrixTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<SolverPoi2PoiMatrix> SolverPoi2PoiMatrices { get; set; }
    }
}
