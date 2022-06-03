using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PromyRelacje
    {
        public int IdPromyRelacje { get; set; }
        public string Nazwa { get; set; }
        public string Symbol { get; set; }
        public int? MiejsceZaId { get; set; }
        public string MiejsceZaNazwa { get; set; }
        public string MiejsceZaAdres { get; set; }
        public string MiejsceZaMiasto { get; set; }
        public string MiejsceZaKod { get; set; }
        public string MiejsceZaKraj { get; set; }
        public int? MiejsceWyId { get; set; }
        public string MiejsceWyNazwa { get; set; }
        public string MiejsceWyAdres { get; set; }
        public string MiejsceWyMiasto { get; set; }
        public string MiejsceWyKod { get; set; }
        public string MiejsceWyKraj { get; set; }
        public double? MiejsceZaGeoLongi { get; set; }
        public double? MiejsceZaGeoLat { get; set; }
        public double? MiejsceWyGeoLongi { get; set; }
        public double? MiejsceWyGeoLat { get; set; }
        public DateTime? CzasPlyniecia { get; set; }
        public int? WaznoscBookingu { get; set; }
        public string Uwagi { get; set; }
        public string Lokalizacja { get; set; }
        public int? Aktywna { get; set; }
    }
}
