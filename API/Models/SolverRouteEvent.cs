using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverRouteEvent
    {
        public SolverRouteEvent()
        {
            SolverRouteEventBundles = new HashSet<SolverRouteEventBundle>();
            SolverRouteEventCosts = new HashSet<SolverRouteEventCost>();
            SolverRouteEventOrders = new HashSet<SolverRouteEventOrder>();
        }

        public int SolverRouteId { get; set; }
        public int EventRoutePos { get; set; }
        public int EventTypeId { get; set; }
        public string EventTypeScope { get; set; }
        public DateTime? EventDate { get; set; }
        public double? EventRouteDistance { get; set; }
        public int IsValid { get; set; }

        public virtual SolverEventType EventType { get; set; }
        public virtual SolverRoute SolverRoute { get; set; }
        public virtual SolverRouteEventGate SolverRouteEventGate { get; set; }
        public virtual ICollection<SolverRouteEventBundle> SolverRouteEventBundles { get; set; }
        public virtual ICollection<SolverRouteEventCost> SolverRouteEventCosts { get; set; }
        public virtual ICollection<SolverRouteEventOrder> SolverRouteEventOrders { get; set; }
    }
}
