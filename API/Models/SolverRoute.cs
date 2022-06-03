using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverRoute
    {
        public SolverRoute()
        {
            SolverRouteBundles = new HashSet<SolverRouteBundle>();
            SolverRouteEvents = new HashSet<SolverRouteEvent>();
            SolverRouteRelationSolverRoutes = new HashSet<SolverRouteRelation>();
            SolverRouteRelations = new HashSet<SolverRouteRelation>();
        }

        public int SolverRouteId { get; set; }
        public int SolverSolutionId { get; set; }
        public int SolverTaskId { get; set; }
        public int? SolverCarrierId { get; set; }
        public double? Cost { get; set; }
        public double? Distance { get; set; }
        public double? Duration { get; set; }
        public int? SolverTruckProfileId { get; set; }
        public string GroupName { get; set; }
        public int? FleetId { get; set; }

        public virtual SolverCarrier Solver { get; set; }
        public virtual SolverFleet SolverFleet { get; set; }
        public virtual SolverSolution SolverSolution { get; set; }
        public virtual SolverTruckProfile SolverT { get; set; }
        public virtual ICollection<SolverRouteBundle> SolverRouteBundles { get; set; }
        public virtual ICollection<SolverRouteEvent> SolverRouteEvents { get; set; }
        public virtual ICollection<SolverRouteRelation> SolverRouteRelationSolverRoutes { get; set; }
        public virtual ICollection<SolverRouteRelation> SolverRouteRelations { get; set; }
    }
}
