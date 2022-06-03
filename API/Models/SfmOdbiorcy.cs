using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmOdbiorcy
    {
        public int IdSfmOdbiorcy { get; set; }
        public int IdSfmGrupyodb { get; set; }
        public int IdSfmTerm { get; set; }
        public string TypTerm { get; set; }
        public string SymbolTerm { get; set; }
        public int IdSfmTabor { get; set; }
        public int IdTabor { get; set; }
        public string NrRej { get; set; }
        public string NrInwent { get; set; }
        public int? IdKierowcy { get; set; }
        public string Kierowca { get; set; }
    }
}
