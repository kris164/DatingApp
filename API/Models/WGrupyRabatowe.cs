using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WGrupyRabatowe
    {
        public int IdWGrupyRabatowe { get; set; }
        public string Kod { get; set; }
        public string Opis { get; set; }
        public string RodzajZlecenia { get; set; }
        public string GrupaT { get; set; }
        public string GrupaU { get; set; }
        public double? MarzaT { get; set; }
        public double? MarzaU { get; set; }
        public double? RabatT { get; set; }
        public double? RabatU { get; set; }
    }
}
