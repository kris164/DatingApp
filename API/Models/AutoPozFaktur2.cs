using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class AutoPozFaktur2
    {
        public int IdAutoPozFaktur2 { get; set; }
        public string RodzPrzychodow { get; set; }
        public string Kierunek { get; set; }
        public string RodzTransp { get; set; }
        public string Klient { get; set; }
        public string Odcinek { get; set; }
        public string KwotaWg { get; set; }
        public int? PozycjaId { get; set; }
        public string Pozycja { get; set; }
        public int? PozycjaZb1Id { get; set; }
        public string PozycjaZb1 { get; set; }
        public int? PozycjaZb2Id { get; set; }
        public string PozycjaZb2 { get; set; }
        public string VatId { get; set; }
        public double? Vat { get; set; }
        public string Konto { get; set; }
    }
}
