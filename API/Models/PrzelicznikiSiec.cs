using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PrzelicznikiSiec
    {
        public int IdPrzelicznikiSiec { get; set; }
        public int? WartoscZ { get; set; }
        public string JmZ { get; set; }
        public int? WartoscDo { get; set; }
        public string JmDo { get; set; }
        public double? Jt { get; set; }
    }
}
