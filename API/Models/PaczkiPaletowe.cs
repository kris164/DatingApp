using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PaczkiPaletowe
    {
        public int IdPaczkiPaletowe { get; set; }
        public int PaczkiId { get; set; }
        public int PrzesylkiId { get; set; }
        public int PaczkiPalId { get; set; }
        public int PrzesylkiPalId { get; set; }
        public double Ilosc { get; set; }
        public double IloscRozl { get; set; }
        public int? BilansOpakLokId { get; set; }
        public int? BilansOpakLokPozId { get; set; }
    }
}
