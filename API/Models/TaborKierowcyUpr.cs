using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaborKierowcyUpr
    {
        public int IdTaborKierowcyUpr { get; set; }
        public int? TaborId { get; set; }
        public int? KierowcaId { get; set; }
        public DateTime? DtOd { get; set; }
        public DateTime? DtDo { get; set; }
    }
}
