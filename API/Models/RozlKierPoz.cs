using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RozlKierPoz
    {
        public int IdRozlKierPoz { get; set; }
        public int? RozlKierId { get; set; }
        public int? KierowcaId { get; set; }
        public string Kierowca { get; set; }
        public double? PensjaPodst { get; set; }
        public double? KmStawka { get; set; }
        public double? IloscKm { get; set; }
        public double? PensjaKm { get; set; }
        public double? PensjaOdZlec { get; set; }
        public double? Dodatki { get; set; }
        public double? Odliczenia { get; set; }
        public double? DoWyplaty { get; set; }
        public double? Zaliczki { get; set; }
        public double? Pozostalo { get; set; }
        public int? Rozliczono { get; set; }
        public string Uwagi { get; set; }
        public double? Kwota1 { get; set; }
        public double? Kwota2 { get; set; }
        public double? Kwota3 { get; set; }
        public double? Kwota4 { get; set; }
        public double? Kwota5 { get; set; }
        public double? Kwota6 { get; set; }
        public double? Kwota7 { get; set; }
        public double? Kwota8 { get; set; }
        public double? Kwota9 { get; set; }
        public double? Kwota10 { get; set; }
    }
}
