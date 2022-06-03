using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Trasy
    {
        public int IdTrasy { get; set; }
        public int? KlientId { get; set; }
        public string Klient { get; set; }
        public string NazwaTrasy { get; set; }
        public int? MiejsceNadId { get; set; }
        public string MiejsceNad { get; set; }
        public string KrajNad { get; set; }
        public int? MiejsceOdbId { get; set; }
        public string MiejsceOdb { get; set; }
        public string KrajOdb { get; set; }
        public string Kierunek { get; set; }
        public double? Odleglosc { get; set; }
        public double? CenaZaFracht { get; set; }
        public string KodTrasy { get; set; }
        public string Waluta { get; set; }
        public double? CenaZaFrachtP { get; set; }
        public string WalutaP { get; set; }
        public string Lokalizacja { get; set; }
        public int? Ftl { get; set; }
        public int? Drobnica { get; set; }
        public int? PrzepisujKmDo { get; set; }
        public double? OdlegloscDojazd { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
