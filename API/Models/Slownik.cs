using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Slownik
    {
        public int IdSlownik { get; set; }
        public string Symbol { get; set; }
        public string Kod { get; set; }
        public string Opis { get; set; }
    }
}
