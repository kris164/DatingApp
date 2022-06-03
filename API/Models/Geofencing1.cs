using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Geofencing1
    {
        public int GeofencingId { get; set; }
        public int? AreaId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ObjectTypeId { get; set; }
        public int? ObjectId { get; set; }
        public int? VehicleId { get; set; }
        public int? DriverId { get; set; }
        public int? ServicedByTelematics { get; set; }
        public int? Template { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? ModifyUserId { get; set; }
        public DateTime? ModifyTime { get; set; }
    }
}
