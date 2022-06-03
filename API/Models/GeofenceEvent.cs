using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class GeofenceEvent
    {
        public int GeofenceEventId { get; set; }
        public int? ObjectId { get; set; }
        public int? RecordId { get; set; }
        public int? Detail1 { get; set; }
        public int? Detail2 { get; set; }
        public int? Detail3 { get; set; }
        public int? GeofenceId { get; set; }
        public int? Active { get; set; }
        public int? Sequence { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public int? ModifyUserId { get; set; }
        public string ModifyUserName { get; set; }
        public DateTime? ModifyDateTime { get; set; }
    }
}
