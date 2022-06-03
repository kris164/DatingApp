using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class GeofencingEvent
    {
        public int GeofencingEventId { get; set; }
        public int? GeofencingId { get; set; }
        public int? EventTypeId { get; set; }
        public int? ActionTypeId { get; set; }
        public DateTime? Date { get; set; }
        public int? Minute { get; set; }
        public int? Active { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidUntil { get; set; }
        public int? NumberOfUse { get; set; }
        public int? EventCount { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? ModifyUserId { get; set; }
        public DateTime? ModifyTime { get; set; }
    }
}
