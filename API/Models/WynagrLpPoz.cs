using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WynagrLpPoz
    {
        public int IdWynagrLpPoz { get; set; }
        public int? WynagrLpId { get; set; }
        public int? WynagrSchematPozId { get; set; }
        public int? Lp { get; set; }
        public string Nazwa { get; set; }
        public string Parametry { get; set; }
        public string Opis { get; set; }
        public string Skrypt { get; set; }
        public double? MnoznikSolo { get; set; }
        public double? MnoznikI { get; set; }
        public double? MnoznikIi { get; set; }
        public double? Mnoznik { get; set; }
        public double? SumaWyliczona { get; set; }
        public double? SumaDoWyplaty { get; set; }
        public int? LiczTylkoRaz { get; set; }
        public int? DekretNaPw { get; set; }
        public int? DekretNaPwAlg { get; set; }
        public int? DekretNaZlec { get; set; }
        public int? DekretNaZlecAlg { get; set; }
        public string RodzKosztow { get; set; }
        public string ProceduraDb { get; set; }
        public string ProceduraDbInfo { get; set; }
    }
}
