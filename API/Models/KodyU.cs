using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Kody urzędów skarbowych
    /// </summary>
    public partial class KodyU
    {
        public int IdKodyUs { get; set; }
        public string Symbol { get; set; }
        public string Opis { get; set; }
    }
}
