using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// definicje list słowników
    /// </summary>
    public partial class SfmSloDef
    {
        public int IdSfmSloDef { get; set; }
        /// <summary>
        /// kod słownika
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// opis słownika
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// definicja parametrów dodatkowych
        /// </summary>
        public string Parametry { get; set; }
    }
}
