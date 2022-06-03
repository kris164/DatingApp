using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik wyposażenia teczek pojazdów
    /// </summary>
    public partial class WypTeczkiTaboru
    {
        public int IdWypTeczkiTaboru { get; set; }
        /// <summary>
        /// Lp
        /// </summary>
        public int? Lp { get; set; }
        /// <summary>
        /// Opis
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Flaga, czy element służy do planowania
        /// </summary>
        public int? DoPlanowania { get; set; }
        /// <summary>
        /// Flaga, czy element służy do rozliczenia
        /// </summary>
        public int? DoRozliczenia { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
        public int? Visible { get; set; }
    }
}
