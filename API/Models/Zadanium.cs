using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Zadanium
    {
        public int IdZadania { get; set; }
        public string Zlecext { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Godzod { get; set; }
        public DateTime? Godzdo { get; set; }
        public string Info { get; set; }
        public string Lokalizacja { get; set; }
        public int? ZaPoiId { get; set; }
        public string ZaPoiSymbol { get; set; }
        public int? WyPoiId { get; set; }
        public string WyPoiRegion { get; set; }
        public string WyPoiSymbol { get; set; }
        public string WyPoiOpis { get; set; }
        public short? Plancalk { get; set; }
        public string Rodzaj { get; set; }
        public double? Ilosc { get; set; }
        public double? Waga { get; set; }
        public string Uwagi { get; set; }
        public string Typodbiorcy { get; set; }
        public string Klasapojazdu { get; set; }
        public string Zbiornik { get; set; }
        public short? Status { get; set; }
        public DateTime? ZaDt { get; set; }
        public DateTime? ZaGodzod { get; set; }
        public DateTime? ZaGodzdo { get; set; }
        /// <summary>
        /// gęstość paliwa 1 15°C
        /// </summary>
        public double? Gestosc { get; set; }
        public DateTime? RzDtZa { get; set; }
        public DateTime? RzDtWy { get; set; }
    }
}
