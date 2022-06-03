using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik usług innych
    /// </summary>
    public partial class OthPoz
    {
        public int IdOthPoz { get; set; }
        public string Kod { get; set; }
        public string Opis { get; set; }
        public string Jm { get; set; }
    }
}
