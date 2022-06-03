using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Kursy
    {
        public int TabelaId { get; set; }
        public string Waluta { get; set; }
        public int KursNa { get; set; }
        public double? Kurs { get; set; }
        public double? Kupno { get; set; }
        public double? Sprzedaz { get; set; }
    }
}
