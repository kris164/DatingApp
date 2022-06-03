using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PrzelewyRachunki
    {
        public int IdPrzelewyRachunki { get; set; }
        public int? KontrahId { get; set; }
        public string Kontrah { get; set; }
        public string Bank { get; set; }
        public string Nazwa { get; set; }
        public string Swift { get; set; }
        public string Numer { get; set; }
        public string Waluta { get; set; }
        public int? TypPliku { get; set; }
        public int? Kodowanie { get; set; }
        public int? TylkoJedenKontrah { get; set; }
        public int? BezRef { get; set; }
        public string Wersja { get; set; }
        public int? Domyslny { get; set; }
        public string Cif { get; set; }
        public string KrajIban { get; set; }
        public int? TypPlikuZagr { get; set; }
        public string DefZagr { get; set; }
        public string DefOplaty { get; set; }
        public string DefOplatyRach { get; set; }
        public int? DefSepa { get; set; }
        public string Lokalizacja { get; set; }
        public int? ElixirSplitSep { get; set; }
        public int? OgrIloscPrzelWPaczce { get; set; }
    }
}
