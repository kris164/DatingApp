using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaborGrupySpedytorzy
    {
        public int IdTaborGrupySpedytorzy { get; set; }
        public int? TaborGrupyId { get; set; }
        public int? SpedytorId { get; set; }
        public string Spedytor { get; set; }
        public DateTime? DtOd { get; set; }
        public DateTime? DtDo { get; set; }
    }
}
