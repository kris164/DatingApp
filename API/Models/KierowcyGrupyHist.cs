using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class KierowcyGrupyHist
    {
        public int IdKierowcyGrupyHist { get; set; }
        public int? KierowcyId { get; set; }
        public int? KierowcyGrupyId { get; set; }
        public DateTime? DataOd { get; set; }
        public DateTime? GodzOd { get; set; }
    }
}
