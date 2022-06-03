using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class GeofenceEventDatum
    {
        public int GeofenceEventDataId { get; set; }
        public int? GeofenceEventId { get; set; }
        public string DeviceInfo { get; set; }
        public int? GeofenceEnter { get; set; }
        public int? GeofenceExit { get; set; }
        public DateTime? EventDate { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public double? Altitude { get; set; }
        public double? Speed { get; set; }
        public double? TrueHeading { get; set; }
        public double? ErrorRadius { get; set; }
        public int? Satellite { get; set; }
        public int? Done { get; set; }
    }
}
