using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WTerminarz
    {
        public int IdWTerminarz { get; set; }
        public int? WZlecenieId { get; set; }
        public string WZlecenie { get; set; }
        public int? WStanowiskaId { get; set; }
        public string WStanowiska { get; set; }
        public string Subject { get; set; }
        public string Notes { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? EndTime { get; set; }
        public int? Alarm { get; set; }
        public DateTime? AlarmDate { get; set; }
        public DateTime? AlarmTime { get; set; }
        public int? EventType { get; set; }
        public int? Options { get; set; }
        public int? Color { get; set; }
        public int? State { get; set; }
        public string Location { get; set; }
        public int? WZlecenieOfertyId { get; set; }
        public int? WZleceniaOfertyId { get; set; }
    }
}
