using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmStat
    {
        public int IdSfmStat { get; set; }
        public int? IdSfmMsg { get; set; }
        public int? MacroNr { get; set; }
        public int? MacroVer { get; set; }
        public int IdSfmTerm { get; set; }
        public string TypTerm { get; set; }
        public string SymbolTerm { get; set; }
        public int IdSfmTabor { get; set; }
        public int IdTabor { get; set; }
        public string NrRej { get; set; }
        public string NrInwent { get; set; }
        public int? IdKierowcy { get; set; }
        public string Kierowca { get; set; }
        public int? IdKierowcy2 { get; set; }
        public string Kierowca2 { get; set; }
        public int? IdZlecenia { get; set; }
        public string Nrzlec { get; set; }
        public int? IdZa { get; set; }
        public int? IdWy { get; set; }
        public int? IdSfmPos { get; set; }
        public DateTime? DtZapis { get; set; }
        public DateTime? DtStat { get; set; }
        public short? StatKoniec { get; set; }
        public int? StatKierowca { get; set; }
        public int? StatKierowca2 { get; set; }
        public int? StatTabor { get; set; }
        public int? StatTabor2 { get; set; }
        public double? StatWartosc { get; set; }
        public int? StatZlec { get; set; }
        public string StatTekst { get; set; }
        public short? Drugikierowca { get; set; }
    }
}
