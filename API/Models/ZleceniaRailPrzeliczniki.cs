using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ZleceniaRailPrzeliczniki
    {
        public int IdZleceniaRailPrzeliczniki { get; set; }
        public int? ZleceniaRailId { get; set; }
        public int? WartoscZ { get; set; }
        public string JmZ { get; set; }
        public int? WartoscDo { get; set; }
        public string JmDo { get; set; }
        public double? Jt { get; set; }
    }
}
