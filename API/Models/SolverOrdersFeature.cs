using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverOrdersFeature
    {
        public int SolverTaskId { get; set; }
        public int SolverOrderId { get; set; }
        public int FeatureTypeId { get; set; }
        public double FeatureValue { get; set; }

        public virtual SolverOrdersFeatureType FeatureType { get; set; }
        public virtual SolverOrder Solver { get; set; }
    }
}
