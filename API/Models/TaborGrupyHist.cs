using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaborGrupyHist
    {
        public int IdTaborGrupyHist { get; set; }
        public int? TaborId { get; set; }
        public int? TaborGrupyId { get; set; }
        public DateTime? DataOd { get; set; }
        public DateTime? GodzOd { get; set; }
        public int? Licznik { get; set; }
        public int? LicznikMth { get; set; }
    }
}
