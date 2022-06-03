using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaborOCennikKgkm
    {
        public int IdTaborOCennikKgkm { get; set; }
        public int? TaborOId { get; set; }
        public double? WagaOd { get; set; }
        public double? WagaDo { get; set; }
        public double? Stawka { get; set; }
    }
}
