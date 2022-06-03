using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WindykacjeHarm
    {
        public int IdWindykacjeHarm { get; set; }
        public int? WindykacjeId { get; set; }
        public int? Lp { get; set; }
        public DateTime? Termin { get; set; }
        public double? Kwota { get; set; }
        public string Opis { get; set; }
        public int? Splata { get; set; }
    }
}
