using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RejKosztOgPoz
    {
        public int IdRejKosztOgPoz { get; set; }
        public int? RejKosztOgId { get; set; }
        public int? FakturaId { get; set; }
        public string RodzKosztow { get; set; }
        public string Waluta { get; set; }
        public double? Kwota { get; set; }
    }
}
