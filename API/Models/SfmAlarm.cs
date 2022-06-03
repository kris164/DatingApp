using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmAlarm
    {
        public int IdSfmAlarm { get; set; }
        /// <summary>
        /// źródło: ID systemu telematycznego
        /// </summary>
        public int? IdSfmSystem { get; set; }
        public int? IdSfmMsg { get; set; }
        public int IdSfmTerm { get; set; }
        public string TypTerm { get; set; }
        public string SymbolTerm { get; set; }
        public int IdSfmTabor { get; set; }
        public int IdTabor { get; set; }
        public string NrRej { get; set; }
        public string NrInwent { get; set; }
        public int? IdKierowcy { get; set; }
        public string Kierowca { get; set; }
        public int? IdGrupy { get; set; }
        public int? IdUzytk { get; set; }
        public string Nazwauzytk { get; set; }
        public int? IdZlecenia { get; set; }
        public string Nrzlec { get; set; }
        public int? IdZa { get; set; }
        public int? IdWy { get; set; }
        public int? IdSfmPos { get; set; }
        public int? Typ { get; set; }
        public short? Zrodlo { get; set; }
        public short? Systemowy { get; set; }
        public short? Popup { get; set; }
        public string Tekst { get; set; }
        public short? Status { get; set; }
        public DateTime? DtZapis { get; set; }
        public DateTime? DtAlarm { get; set; }
        public DateTime? DtStart { get; set; }
        public DateTime? DtKoniec { get; set; }
        public int? SIdUzytk { get; set; }
        public string SNazwauzytk { get; set; }
        public int? KIdUzytk { get; set; }
        public string KNazwauzytk { get; set; }
    }
}
