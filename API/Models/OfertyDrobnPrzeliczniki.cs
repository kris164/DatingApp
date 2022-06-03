using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class OfertyDrobnPrzeliczniki
    {
        public int IdOfertyDrobnPrzeliczniki { get; set; }
        public int? OfertyDrobnUslugiId { get; set; }
        public int? WartoscZ { get; set; }
        public string JmZ { get; set; }
        public int? WartoscDo { get; set; }
        public string JmDo { get; set; }
        public double? Jt { get; set; }
    }
}
