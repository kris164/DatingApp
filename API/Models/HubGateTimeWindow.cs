using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class HubGateTimeWindow
    {
        public int HubGateTimeWindowId { get; set; }
        public int HubGateId { get; set; }
        public int? DayNumber { get; set; }
        public DateTime? TimeBegin { get; set; }
        public DateTime? TimeEnd { get; set; }
        public int? Active { get; set; }
        public int? Color { get; set; }
        public int HubGateEventTypeId { get; set; }
    }
}
