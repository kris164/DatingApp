using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class FakturyDekret
    {
        public int IdFakturyDekret { get; set; }
        public int? FakturyId { get; set; }
        public string Strona { get; set; }
        public string Konto { get; set; }
        public double? Kwota { get; set; }
    }
}
