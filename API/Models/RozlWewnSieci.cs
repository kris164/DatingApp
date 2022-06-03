using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RozlWewnSieci
    {
        public int IdRozlWewnSieci { get; set; }
        public DateTime? DataOd { get; set; }
        public DateTime? DataDo { get; set; }
        public int? Typ { get; set; }
        public int? WgDaty { get; set; }
        public int? CennikId { get; set; }
        public string Cennik { get; set; }
        public string Uwagi { get; set; }
        public string Status { get; set; }
        public string Lokalizacja { get; set; }
        public int? CennikSzukajId { get; set; }
        public string CennikSzukaj { get; set; }
    }
}
