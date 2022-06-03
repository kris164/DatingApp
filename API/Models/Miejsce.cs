using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Miejsce
    {
        public int IdMiejsce { get; set; }
        public int? IdStrefa { get; set; }
        public int? IdMagazyn { get; set; }
        public string Kod { get; set; }
        public string KodMagazyn { get; set; }
        public string KodStrefa { get; set; }
        public int? Brama { get; set; }
    }
}
