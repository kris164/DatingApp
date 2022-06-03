using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TrasyWyznaczniki
    {
        public int IdTrasyWyznaczniki { get; set; }
        public int? TrasyId { get; set; }
        public int? Nr { get; set; }
        public string Typ { get; set; }
        public int? MiejsceId { get; set; }
        public string Miejsce { get; set; }
        public string Kraj { get; set; }
        public double? GeoLongi { get; set; }
        public double? GeoLat { get; set; }
    }
}
