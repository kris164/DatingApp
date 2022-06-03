using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class KarnetyTir
    {
        public int IdKarnetyTir { get; set; }
        public string NrKarnetu { get; set; }
        public string TypKarnetu { get; set; }
        public DateTime? DataWaznosci { get; set; }
        public double? WartoscNetto { get; set; }
        public string Waluta { get; set; }
        public string VatId { get; set; }
        public double? VatStawka { get; set; }
        public int? FakturaId { get; set; }
        public string Faktura { get; set; }
        public int? WyjazdId { get; set; }
        public string Wyjazd { get; set; }
        public int? ZlecenieId { get; set; }
        public string Zlecenie { get; set; }
        public int? KierowcaId { get; set; }
        public string Kierowca { get; set; }
        public int? WydanyPrzezId { get; set; }
        public string WydanyPrzez { get; set; }
        public DateTime? DataWydania { get; set; }
        public int? Zwrot { get; set; }
        public DateTime? DataZwrotu { get; set; }
        public int? Rozliczono { get; set; }
        public DateTime? DataRozliczenia { get; set; }
        public string Uwagi { get; set; }
        public string Lokalizacja { get; set; }
        public string NrKarnetuSymbol { get; set; }
        public int? TaborId { get; set; }
        public string Tabor { get; set; }
        public string Trasa { get; set; }
        public string Dzial { get; set; }
        public int? Zalaczniki { get; set; }
    }
}
