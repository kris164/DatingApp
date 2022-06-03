using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class LogEtum
    {
        public int SessionId { get; set; }
        public int? OrderId { get; set; }
        public int IdZlecenia { get; set; }
        public int IdZleceniaZaWy { get; set; }
        public string NrZlecenia { get; set; }
        public DateTime? DtEta { get; set; }
        public int? IdTaboru { get; set; }
    }
}
