using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverEventType
    {
        public SolverEventType()
        {
            SolverRouteEvents = new HashSet<SolverRouteEvent>();
        }

        public int EventTypeId { get; set; }
        public string EventTypeScope { get; set; }
        public string Name { get; set; }

        public virtual ICollection<SolverRouteEvent> SolverRouteEvents { get; set; }
    }
}
