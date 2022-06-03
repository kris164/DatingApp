using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// ADR-UN wyłączone z selekcji
    /// </summary>
    public partial class AdrUnList
    {
        public int IdAdrUnList { get; set; }
        /// <summary>
        /// Kod UN
        /// </summary>
        public string Un { get; set; }
        /// <summary>
        /// Klasa
        /// </summary>
        public string Klasa { get; set; }
        /// <summary>
        /// Kod klasyfikacyjny
        /// </summary>
        public string KodKlasyfik { get; set; }
        /// <summary>
        /// Grupa pakowania
        /// </summary>
        public string GrupaPakow { get; set; }
        /// <summary>
        /// Nalepki
        /// </summary>
        public string Nalepki { get; set; }
    }
}
