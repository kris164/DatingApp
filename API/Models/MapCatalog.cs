using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MapCatalog
    {
        public int MapCatalogId { get; set; }
        public string Label { get; set; }
        public int? VehicleId { get; set; }
        public int? Payments { get; set; }
        public int? Highways { get; set; }
        public int? Tunnels { get; set; }
        public int? RouteRestrictionsPenalty { get; set; }
        public int? Ferries { get; set; }
        public int? RoutingType { get; set; }
        public string Hazardous { get; set; }
        public decimal? CostConstant { get; set; }
        public decimal? CostPerKm { get; set; }
        public decimal? CostPerHour { get; set; }
        public string CostCurrency { get; set; }
        public decimal? CostTotal { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime? CreateDatetime { get; set; }
        public int? ModifyUserId { get; set; }
        public DateTime? ModifyDatetime { get; set; }
        public int? Toll { get; set; }
        public string TollCurrency { get; set; }
        public string TollCurrencyExceptions { get; set; }
    }
}
