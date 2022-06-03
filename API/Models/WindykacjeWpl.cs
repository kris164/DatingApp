using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WindykacjeWpl
    {
        public int IdWindykacjeWpl { get; set; }
        public int? WindykacjeId { get; set; }
        public DateTime? DataWpl { get; set; }
        public double? Kwota { get; set; }
        public string Rodzaj { get; set; }
        public string Opis { get; set; }
        public int? FakturyId { get; set; }
        public int? NotyId { get; set; }
        public int? FakturySplatyId { get; set; }
        public int? NotySplatyId { get; set; }
    }
}
