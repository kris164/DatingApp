using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverPoiRelationType
    {
        public SolverPoiRelationType()
        {
            SolverPoiRelations = new HashSet<SolverPoiRelation>();
        }

        public int PoiRelationTypeId { get; set; }
        public string PoiRelationName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<SolverPoiRelation> SolverPoiRelations { get; set; }
    }
}
