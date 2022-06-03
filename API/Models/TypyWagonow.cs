using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TypyWagonow
    {
        public int IdTypyWagonow { get; set; }
        public int RodzajWagonuId { get; set; }
        public string Oznaczenie { get; set; }
        public double? MasaWagonu { get; set; }
        public double? MaxLadA { get; set; }
        public double? MaxLadB1 { get; set; }
        public double? MaxLadB2 { get; set; }
        public double? MaxLadC { get; set; }
        public double? MaxLadD { get; set; }
        public double? MPal { get; set; }
        public double? MaxObj { get; set; }
        public string Uwagi { get; set; }
        public byte[] Zdjecie { get; set; }
        public string Operator { get; set; }
        public int? ToryW { get; set; }
        public int? TorySz { get; set; }
        public int? LOsi { get; set; }
    }
}
