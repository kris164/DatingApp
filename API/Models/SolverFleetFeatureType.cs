using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverFleetFeatureType
    {
        public SolverFleetFeatureType()
        {
            SolverFleetFeatures = new HashSet<SolverFleetFeature>();
        }

        public int FleetFeatureTypeId { get; set; }
        public string FleetFeatureName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<SolverFleetFeature> SolverFleetFeatures { get; set; }
    }
}
