using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaborTerminHist
    {
        public int IdTaborTerminHist { get; set; }
        public int? TaborId { get; set; }
        public string CzynnoscId { get; set; }
        public string Czynnosc { get; set; }
        public string Wskaznik { get; set; }
        public DateTime? DataPlan { get; set; }
        public DateTime? DataWyk { get; set; }
        public int? LicznikPlan { get; set; }
        public int? LicznikWyk { get; set; }
        public string Uwagi { get; set; }
    }
}
