using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpWyjazdyZlecenium
    {
        public int IdTmpWyjazdyZlecenia { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public int? IdWyjazdyZlecenia { get; set; }
        public int? WyjazdId { get; set; }
        public string Wyjazd { get; set; }
        public string TypZlecenia { get; set; }
        public int? ZlecenieId { get; set; }
        public string Zlecenie { get; set; }
        public string Zleceniodawca { get; set; }
        public int? SamochodId { get; set; }
        public string Samochod { get; set; }
        public string SamochodNrBoczny { get; set; }
        public int? NaczepaId { get; set; }
        public string Naczepa { get; set; }
        public string NaczepaNrBoczny { get; set; }
        public int? Kierowca1Id { get; set; }
        public string Kierowca1 { get; set; }
        public int? Kierowca2Id { get; set; }
        public string Kierowca2 { get; set; }
        public int? Kierowca3Id { get; set; }
        public string Kierowca3 { get; set; }
        public double? Waga { get; set; }
        public double? Odleglosc { get; set; }
        public double? OdlegloscLad { get; set; }
        public double? OdlegloscPust { get; set; }
        public double? ProcentKosztow { get; set; }
        public double? FrachtDoProwizji { get; set; }
        public double? PrzychodWewn { get; set; }
        public string PrzychodWewnWal { get; set; }
    }
}
