using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverOrdersRelationRestriction
    {
        public int SolverTaskId { get; set; }
        public int SolverOrder1Id { get; set; }
        public int SolverOrder2Id { get; set; }
        public int RestrictionTypeId { get; set; }

        public virtual SolverOrdersRelationRestrictionType RestrictionType { get; set; }
        public virtual SolverOrder Solver { get; set; }
        public virtual SolverOrder SolverNavigation { get; set; }
    }
}
