using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class DelegacjeLogowanium
    {
        public int IdDelegacjeLogowania { get; set; }
        public int KierowcaId { get; set; }
        public DateTime? Data { get; set; }
        public int? TypPracy { get; set; }
        public int? TypLogowania { get; set; }
        public DateTime Times { get; set; }
    }
}
