using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Typy rozliczeń kalkulacji
    /// </summary>
    public partial class TypRozl
    {
        public int IdTypRozl { get; set; }
        public string Kod { get; set; }
        public string Opis { get; set; }
        public int RozlFv { get; set; }
    }
}
