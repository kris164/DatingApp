using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class OfertyPozycje
    {
        public int IdOfertyPozycje { get; set; }
        public int OfertaId { get; set; }
        public int? OpisTowaruId { get; set; }
        public string OpisTowaru { get; set; }
        public double? WagaLadunku { get; set; }
        public double? ObjetoscLadunku { get; set; }
        public double? Wysokosc { get; set; }
        public double? Szerokosc { get; set; }
        public double? Dlugosc { get; set; }
        public string TypOpakowania { get; set; }
        public double? IloscOpakowan { get; set; }
        public int? IloscTransportow { get; set; }
        public double? CenaZaTransport { get; set; }
        public double? WagaCalosci { get; set; }
        public string JednWagi { get; set; }
        public string TypPojazdu { get; set; }
        public string OpisTowaruHaccp { get; set; }
        public string OpisTowaruSqas { get; set; }
        public int? Cysterna { get; set; }
    }
}
