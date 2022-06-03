using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class DaneAwbOplDod
    {
        public int IdDaneAwbOplDod { get; set; }
        public int DaneAwbId { get; set; }
        public string Symbol { get; set; }
        public double? Wartosc { get; set; }
    }
}
