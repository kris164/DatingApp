using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpPrzesylkiZaWy
    {
        public int IdTmpPrzesylkiZaWy { get; set; }
        public int? IdSesjiKalk { get; set; }
        public string Typ { get; set; }
        public int? Lp { get; set; }
        public int? MiejsceId { get; set; }
        public string Miejsce { get; set; }
        public string Nazwa { get; set; }
        public string Adres { get; set; }
        public string Kod { get; set; }
        public string Miasto { get; set; }
        public string Kraj { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Godz { get; set; }
        public double? Waga { get; set; }
        public string JednWagi { get; set; }
        public double? Palety { get; set; }
        public string Jm { get; set; }
        public double? Obj { get; set; }
        public string TypOdcinka { get; set; }
        public string AirSymbol { get; set; }
        public string AirNrLotu { get; set; }
        public string SeaSymbol { get; set; }
        public string RailSymbol { get; set; }
    }
}
