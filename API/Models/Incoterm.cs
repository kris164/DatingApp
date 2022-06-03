using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Incoterm
    {
        public int IdIncoterms { get; set; }
        public string KodIncoterms { get; set; }
        public int? KlientId { get; set; }
        public string Klient { get; set; }
        public string Opis { get; set; }
    }
}
