using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverPoiRelation
    {
        public int SolverTaskId { get; set; }
        public int SubjectPoiId { get; set; }
        public int ObjectPoiId { get; set; }
        public int PoiRelationTypeId { get; set; }

        public virtual SolverPoiRelationType PoiRelationType { get; set; }
        public virtual SolverPoi S { get; set; }
        public virtual SolverPoi SolverPoi { get; set; }
    }
}
