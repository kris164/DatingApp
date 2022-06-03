using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaborLokHist
    {
        public int IdTaborLokHist { get; set; }
        public int? TaborId { get; set; }
        public string Lokalizacja { get; set; }
        public DateTime? DataOd { get; set; }
        public DateTime? GodzOd { get; set; }
        public int? Licznik { get; set; }
        public int? LicznikMth { get; set; }
        public string Dzial { get; set; }
        public string KontoFk { get; set; }
        public int? SpedytorId { get; set; }
        public string Spedytor { get; set; }
    }
}
