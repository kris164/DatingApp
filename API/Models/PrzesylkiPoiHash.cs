using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PrzesylkiPoiHash
    {
        public int IdPrzesylkiPoiHash { get; set; }
        public int? IdPrzesylki { get; set; }
        public string Typ { get; set; }
        public string PoiHash { get; set; }
        public double? Lat { get; set; }
        public double? Lon { get; set; }
        public int? Poziom { get; set; }
    }
}
