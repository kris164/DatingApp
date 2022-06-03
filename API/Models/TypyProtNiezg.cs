using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TypyProtNiezg
    {
        public int IdTypyProtNiezg { get; set; }
        public string Typ { get; set; }
        public string Opis { get; set; }
        public int? NadajStatus { get; set; }
        public string Status { get; set; }
        public int? Uszk { get; set; }
        public string SymbolUszk { get; set; }
        public string OpisUszk { get; set; }
        public string OpisUszkUzup { get; set; }
    }
}
