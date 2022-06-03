using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik typów pojazdów
    /// </summary>
    public partial class TypyPojazdow
    {
        public int IdTypyPojazdow { get; set; }
        /// <summary>
        /// Kod typu pojazdu
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// Opis
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Flaga, czy pojazd samobieżny
        /// </summary>
        public int? Samobiezny { get; set; }
        /// <summary>
        /// Flaga, czy pojazd ładowny
        /// </summary>
        public int? Ladowny { get; set; }
        /// <summary>
        /// Flaga, czy pojazd jest cysterną
        /// </summary>
        public int? Cysterna { get; set; }
        /// <summary>
        /// Wyróznik
        /// </summary>
        public string Wyroznik { get; set; }
        /// <summary>
        /// Flaga, czy pojazd jest osobowy
        /// </summary>
        public int? Osobowy { get; set; }
        /// <summary>
        /// Flaga, czy sprzęt roboczy
        /// </summary>
        public int? Sprzet { get; set; }
        /// <summary>
        /// Opis dod
        /// </summary>
        public string OpisDod { get; set; }
        /// <summary>
        /// Flaga, czy kontener
        /// </summary>
        public int? Kontener { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
