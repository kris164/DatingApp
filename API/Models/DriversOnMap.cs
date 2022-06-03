using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class DriversOnMap
    {
        public int DriversOnMapId { get; set; }
        public int PlannerTypeId { get; set; }
        public int SessionId { get; set; }
        public int UserId { get; set; }
        public int DriverId { get; set; }
    }
}
