using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class DaneAwbKoszty
    {
        public int IdDaneAwbKoszty { get; set; }
        public int DaneAwbId { get; set; }
        public double? Quantity { get; set; }
        public double? GrossWeight { get; set; }
        public string Jm { get; set; }
        public string RateClass { get; set; }
        public double? Volume { get; set; }
        public string Commodity { get; set; }
        public double? ChargeableWeight { get; set; }
        public double? Rate { get; set; }
        public string Total { get; set; }
        public int? No { get; set; }
    }
}
