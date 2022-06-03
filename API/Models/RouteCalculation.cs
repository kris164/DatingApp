using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RouteCalculation
    {
        public int RouteCalculationId { get; set; }
        public int? BillOfLadingId { get; set; }
        public int? ShipmentId { get; set; }
        public int? PackageId { get; set; }
        public bool? Calculate { get; set; }
        public int? SaveUserId { get; set; }
        public string SaveUser { get; set; }
    }
}
