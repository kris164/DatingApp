using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class DodPaliwowe
    {
        public int IdDodPaliwowe { get; set; }
        public DateTime? DataOd { get; set; }
        public DateTime? DataDo { get; set; }
        public string Dotyczy { get; set; }
        public string Opis { get; set; }
        public string Algorytm { get; set; }
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
    }
}
