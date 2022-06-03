using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class FtlCalcEvent
    {
        public int IdFtlCalcEvents { get; set; }
        public int? IdFtlCalc { get; set; }
        public int? Order { get; set; }
        public int? IdPoi { get; set; }
        public string PoiType { get; set; }
        public DateTime? EventDt { get; set; }
        public double? Weight { get; set; }
        public double? Capacity { get; set; }
        public double? Quantity { get; set; }
        public double? PalletPlaces { get; set; }
        public int? Approach { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
        public double? Lon { get; set; }
        public double? Lat { get; set; }
    }
}
