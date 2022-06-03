using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverRouteRelation
    {
        public int SolverSolutionId { get; set; }
        public int SubjectRouteId { get; set; }
        public int ObjectRouteId { get; set; }
        public int RouteRelationTypeId { get; set; }

        public virtual SolverRouteRelationType RouteRelationType { get; set; }
        public virtual SolverRoute S { get; set; }
        public virtual SolverRoute SolverRoute { get; set; }
    }
}
