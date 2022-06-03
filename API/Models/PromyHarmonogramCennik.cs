using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PromyHarmonogramCennik
    {
        public int IdPromyHarmonogramCennik { get; set; }
        public string Nazwa { get; set; }
        public byte[] Ikona { get; set; }
        public int? Kolor { get; set; }
    }
}
