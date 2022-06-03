using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MandatyWykroczRozl
    {
        public int IdMandatyWykroczRozl { get; set; }
        public int? MandatyWykroczId { get; set; }
        public string Strona { get; set; }
        public double? Wartosc { get; set; }
        public string Waluta { get; set; }
        public int? IleRat { get; set; }
        public double? WartoscRaty { get; set; }
        public string WalutaRaty { get; set; }
        public DateTime? SplataRatOd { get; set; }
        public DateTime? SplataRatDo { get; set; }
        public string PodstRozl { get; set; }
        public string Uwagi { get; set; }
        public string Status { get; set; }
    }
}
