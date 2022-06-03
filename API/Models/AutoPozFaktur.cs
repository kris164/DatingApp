using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class AutoPozFaktur
    {
        public int IdAutoPozFaktur { get; set; }
        public int? Zb { get; set; }
        public string RodzFv { get; set; }
        public int? TypFv { get; set; }
        public string Odc { get; set; }
        public int? PozycjaId { get; set; }
        public string Pozycja { get; set; }
        public string VatId { get; set; }
        public double? Vat { get; set; }
    }
}
