using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik grup ładunków
    /// </summary>
    public partial class GrupyLadunkow
    {
        public int IdGrupyLadunkow { get; set; }
        /// <summary>
        /// Kod grupy
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// Opis grupy
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Flaga, czy towar podwyższonego ryzyka
        /// </summary>
        public int? PodwRyzyko { get; set; }
        /// <summary>
        /// Flaga, czy towar koszerny
        /// </summary>
        public int? Koszerny { get; set; }
        /// <summary>
        /// Flaga, czy dotyczy ubezpieczeń
        /// </summary>
        public int? Ubezp { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
