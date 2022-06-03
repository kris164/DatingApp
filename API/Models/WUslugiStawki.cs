using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WUslugiStawki
    {
        public int IdWUslugiStawki { get; set; }
        public int? Lp { get; set; }
        public string NazwaStawki { get; set; }
        public double? Stawka { get; set; }
    }
}
