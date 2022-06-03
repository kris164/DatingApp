using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RozlKierPozOdl
    {
        public int IdRozlKierPozOdl { get; set; }
        public int? RozlKierPozId { get; set; }
        public int? TytulId { get; set; }
        public string Tytul { get; set; }
        public double? Kwota { get; set; }
        public string Uwagi { get; set; }
    }
}
