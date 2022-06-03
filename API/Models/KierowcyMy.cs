using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class KierowcyMy
    {
        public int IdKierowcyMies { get; set; }
        public int? Rok { get; set; }
        public int? Miesiac { get; set; }
        public double? PensjaPodst { get; set; }
        public double? KmStawka { get; set; }
        public string Uwagi { get; set; }
        public double? SumaPodst { get; set; }
        public double? Suma { get; set; }
    }
}
