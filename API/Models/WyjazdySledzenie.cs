using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WyjazdySledzenie
    {
        public int IdWyjazdySledzenie { get; set; }
        public int? WyjazdId { get; set; }
        public string Wyjazd { get; set; }
        public int? SamochodId { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Godz { get; set; }
        public int? PracownikId { get; set; }
        public string Pracownik { get; set; }
        public string Typ { get; set; }
        public string Kraj { get; set; }
        public string Opis { get; set; }
        public double? Licznik { get; set; }
        public double? Waga { get; set; }
        public double? Paliwo { get; set; }
        public double? GeoLongi { get; set; }
        public double? GeoLat { get; set; }
    }
}
