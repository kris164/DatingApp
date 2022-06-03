using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaborUbezp
    {
        public int IdTaborUbezp { get; set; }
        public int? TaborId { get; set; }
        public string RodzajSkl { get; set; }
        public int? Rata { get; set; }
        public double? Skladka { get; set; }
        public DateTime? DataPlatnosci { get; set; }
        public DateTime? DataZaplaty { get; set; }
        public int? Zaplacona { get; set; }
    }
}
