using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik warunków dostawy
    /// </summary>
    public partial class Wardost
    {
        public int IdWardost { get; set; }
        /// <summary>
        /// Kod INCO
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// Opis
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Flaga, czy zmieniać płatnika
        /// </summary>
        public int? ZmPlatnika { get; set; }
        /// <summary>
        /// Flaga, na jakiego płatnika zmieniać : 0-zlec, 1-nad, 2-odb
        /// </summary>
        public int? ZmPlatnikaNa { get; set; }
        /// <summary>
        /// Flaga, czy jest pobranie za fracht
        /// </summary>
        public int? PobranieZaFracht { get; set; }
        /// <summary>
        /// Flaga, czy aktywne
        /// </summary>
        public int? Aktywne { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
