using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WStanowiska
    {
        public int IdWStanowiska { get; set; }
        public int? Aktywny { get; set; }
        public string Symbol { get; set; }
        public string Opis { get; set; }
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
    }
}
