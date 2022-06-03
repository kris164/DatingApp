using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class OfertaTrasy
    {
        public int IdOfertaTrasy { get; set; }
        public int? OfertaId { get; set; }
        public int? Lp { get; set; }
        public DateTime? DataZal { get; set; }
        public DateTime? GodzZal { get; set; }
        public DateTime? DataRozl { get; set; }
        public DateTime? GodzRozl { get; set; }
        public int? MiejsceZalId { get; set; }
        public int? MiejsceRozlId { get; set; }
        public string MiejsceZal { get; set; }
        public string MiejsceRozl { get; set; }
        public string KrajZal { get; set; }
        public string KrajRozl { get; set; }
        public int? TrasaId { get; set; }
        public string Trasa { get; set; }
        public double? TrasaOdl { get; set; }
        public double? TrasaStawka { get; set; }
        public string TrasaStawkaWal { get; set; }
        public double? TrasaFracht { get; set; }
        public double? ZaGeoLongi { get; set; }
        public double? ZaGeoLat { get; set; }
        public double? WyGeoLongi { get; set; }
        public double? WyGeoLat { get; set; }
        public double? TrasaStawkaZaJm { get; set; }
        public int? LadunekId { get; set; }
        public string Ladunek { get; set; }
        public double? LadunekIlosc { get; set; }
        public string LadunekIloscJm { get; set; }
        public string Uwagi { get; set; }
        public string OpisWymagTaboru { get; set; }
        public int? Cysterna { get; set; }
    }
}
