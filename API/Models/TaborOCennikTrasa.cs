using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaborOCennikTrasa
    {
        public int IdTaborOCennikTrasa { get; set; }
        public int? TaborOId { get; set; }
        public int? TrasaId { get; set; }
        public string Trasa { get; set; }
        public double? Stawka { get; set; }
    }
}
