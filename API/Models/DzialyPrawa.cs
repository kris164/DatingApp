using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Prawa użytkowników do lokalizacji
    /// </summary>
    public partial class DzialyPrawa
    {
        public int IdDzialyPrawa { get; set; }
        /// <summary>
        /// Relacja do działu - tab: DZIALY
        /// </summary>
        public int? DzialyId { get; set; }
        /// <summary>
        /// Kod działu
        /// </summary>
        public string Dzialy { get; set; }
        /// <summary>
        /// Relacja do użytkownika - tab: UZYTKOWNIK
        /// </summary>
        public int? UzytkownikId { get; set; }
        /// <summary>
        /// Flaga, czy ma prawo podglądu danych z działu
        /// </summary>
        public int? Podglad { get; set; }
        /// <summary>
        /// Flaga, czy ma prawo edycji danych z działu
        /// </summary>
        public int? Edycja { get; set; }
    }
}
