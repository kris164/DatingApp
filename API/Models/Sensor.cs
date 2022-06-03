using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Sensor
    {
        public int SensorId { get; set; }
        public string Name { get; set; }
        public int? Category { get; set; }
        public int? MinTime { get; set; }
        public int? MinDistance { get; set; }
        public int? Sleep { get; set; }
        public int? Order { get; set; }
        public int? Active { get; set; }
        public string DeviceInfo { get; set; }
        public int? Detail1 { get; set; }
        public int? Detail2 { get; set; }
        public int? Detail3 { get; set; }
    }
}
