using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SzkodyPrzyczyny
    {
        public int IdSzkodyPrzyczyny { get; set; }
        public int SzkodyId { get; set; }
        public string Opis { get; set; }
        public string Kod { get; set; }
        public int? ReklamacjeId { get; set; }
    }
}
