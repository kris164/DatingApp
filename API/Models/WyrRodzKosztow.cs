using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik wyróżników rodzajów kosztów
    /// </summary>
    public partial class WyrRodzKosztow
    {
        public int IdWyrRodzKosztow { get; set; }
        /// <summary>
        /// Kod wyróżnika
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// Opis wyróżnika
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Flaga, czy używane w licznikach szczegółowych
        /// </summary>
        public int? UzywajWLicznSzcz { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
