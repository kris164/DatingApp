using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MiejscaZaWyMyjnie
    {
        public int IdMiejscaZaRozladunku { get; set; }
        public int? Zrzeszenie { get; set; }
        public int? CertKoszernosci { get; set; }
        public int? WaznoscCertMycia { get; set; }
        public int? Priorytet { get; set; }
        public int? Algorytm { get; set; }
    }
}
