using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpRouteCalculation
    {
        public int IdTmpRouteCalculation { get; set; }
        public int? SessionId { get; set; }
        public int? BillOfLadingId { get; set; }
        public int? ShipmentId { get; set; }
        public int? PackageId { get; set; }
        public int? RouteWaypointId { get; set; }
        public decimal? Lump { get; set; }
        public string LumpCurrency { get; set; }
    }
}
