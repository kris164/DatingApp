using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class EventLog
    {
        public int EventLogId { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? GeofencingId { get; set; }
        public int? GeofencingEventId { get; set; }
        public int? EventTypeId { get; set; }
        public int? ActionTypeId { get; set; }
        public int? DriverId { get; set; }
        public int? VehicleId { get; set; }
        public int? TerminalId { get; set; }
        public int? PositionId { get; set; }
        public DateTime? PositionDate { get; set; }
        public double? Lat { get; set; }
        public double? Lon { get; set; }
        public string ExtraInfo { get; set; }
        public int? Status { get; set; }
        public string LogText { get; set; }
        public string ErrorText { get; set; }
    }
}
