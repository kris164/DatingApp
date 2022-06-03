using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverRouteRelationType
    {
        public SolverRouteRelationType()
        {
            SolverRouteRelations = new HashSet<SolverRouteRelation>();
        }

        public int RouteRelationTypeId { get; set; }
        public string RouteRelationName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<SolverRouteRelation> SolverRouteRelations { get; set; }
    }
}
