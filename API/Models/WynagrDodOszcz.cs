using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WynagrDodOszcz
    {
        public int IdWynagrDodOszcz { get; set; }
        public double? ProgOd { get; set; }
        public double? ProgDo { get; set; }
        public double? StawkaKm { get; set; }
        public string Opis { get; set; }
    }
}
