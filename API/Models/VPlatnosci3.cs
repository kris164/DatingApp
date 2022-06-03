using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class VPlatnosci3
    {
        public short? Typ { get; set; }
        public int? KontrahentId { get; set; }
        public string Waluta { get; set; }
        public double? DoZaplaty { get; set; }
        public int? Ile { get; set; }
        public int? StatusWindykacji { get; set; }
    }
}
