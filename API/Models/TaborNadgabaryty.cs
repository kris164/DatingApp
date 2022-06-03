using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaborNadgabaryty
    {
        public int IdTaboru { get; set; }
        public double? NDlPoklD { get; set; }
        public double? NDlBalkG { get; set; }
        public double? NDlBalkD { get; set; }
        public double? NMaksRozc { get; set; }
        public double? NDlCalk { get; set; }
        public double? NRozstOsi { get; set; }
        public int? COsNaped { get; set; }
        public double? CRozstOsi12 { get; set; }
        public double? CRozstOsi23 { get; set; }
        public double? CRozstOsi34 { get; set; }
        public string Uwagi { get; set; }
        public double? NBezLadunkuRozstOsi { get; set; }
        public int? COsKierowana { get; set; }
        public double? CBezLadunkuRozstOsi12 { get; set; }
        public double? CBezLadunkuRozstOsi23 { get; set; }
        public double? CBezLadunkuRozstOsi34 { get; set; }
    }
}
