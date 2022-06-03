using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverOrdersRelationRestrictionType
    {
        public SolverOrdersRelationRestrictionType()
        {
            SolverOrdersRelationRestrictions = new HashSet<SolverOrdersRelationRestriction>();
        }

        public int RestrictionTypeId { get; set; }
        public string RestrictionName { get; set; }

        public virtual ICollection<SolverOrdersRelationRestriction> SolverOrdersRelationRestrictions { get; set; }
    }
}
