using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaborKontrakt
    {
        public int IdTaborKontrakt { get; set; }
        public int? TaborId { get; set; }
        public DateTime? DtOd { get; set; }
        public DateTime? DtDo { get; set; }
        public int? TaborZastepujacyId { get; set; }
        public int? TaborZastepowanyId { get; set; }
    }
}
