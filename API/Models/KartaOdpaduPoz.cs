using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class KartaOdpaduPoz
    {
        public int IdKartaOdpaduPoz { get; set; }
        public int IdKartaOdpadu { get; set; }
        public DateTime? Data { get; set; }
        public double? Masa { get; set; }
        public string NrRejestracyjny { get; set; }
    }
}
