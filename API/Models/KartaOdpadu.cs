using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class KartaOdpadu
    {
        public int IdKartaOdpadu { get; set; }
        public int Typ { get; set; }
        public int? Rok { get; set; }
        public int? Miesiac { get; set; }
        public int? NumerKarty { get; set; }
        public string NumerKartyWgKlienta { get; set; }
        public int? IdKlient { get; set; }
        public string KlientSymbol { get; set; }
        public string KlientName { get; set; }
        public string KlientRegon { get; set; }
        public string KodOdpadu { get; set; }
        public string RodzajOdpadu { get; set; }
    }
}
