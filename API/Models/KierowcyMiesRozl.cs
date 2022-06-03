using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class KierowcyMiesRozl
    {
        public int IdKierowcyMiesRozl { get; set; }
        public int? KierowcyMiesId { get; set; }
        public int? KierowcaId { get; set; }
        public string Kierowca { get; set; }
        public double? PensjaPodst { get; set; }
        public double? KmStawka { get; set; }
        public double? Km { get; set; }
        public double? PensjaKm { get; set; }
        public string Premia1Typ { get; set; }
        public double? Premia1Proc { get; set; }
        public double? Premia1 { get; set; }
        public string Premia2Typ { get; set; }
        public double? Premia2Proc { get; set; }
        public double? Premia2 { get; set; }
        public string Premia3Typ { get; set; }
        public double? Premia3Proc { get; set; }
        public double? Premia3 { get; set; }
        public string Premia4Typ { get; set; }
        public double? Premia4Proc { get; set; }
        public double? Premia4 { get; set; }
        public double? Odliczenia { get; set; }
        public double? Pensja { get; set; }
        public int? Rozliczono { get; set; }
        public string Uwagi { get; set; }
        public int? Wyplacono { get; set; }
    }
}
