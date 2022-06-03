using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaborKmMy
    {
        public int IdTaborKmMies { get; set; }
        public int? TaborId { get; set; }
        public int? Rok { get; set; }
        public string Miesiac { get; set; }
        public string Typ { get; set; }
        public int? LicznikOd { get; set; }
        public int? LicznikDo { get; set; }
        public double? Km { get; set; }
        public double? Tonaz { get; set; }
    }
}
