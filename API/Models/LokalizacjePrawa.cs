using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Prawa użytkowników do lokalizacji
    /// </summary>
    public partial class LokalizacjePrawa
    {
        public int IdLokalizacjePrawa { get; set; }
        /// <summary>
        /// Relacja do lokalizacji - tab: LOKALIZACJE
        /// </summary>
        public int? LokalizacjeId { get; set; }
        /// <summary>
        /// Kod lokalizacji
        /// </summary>
        public string Lokalizacje { get; set; }
        /// <summary>
        /// Relacja do użytkownika - tab: UZYTKOWNIK
        /// </summary>
        public int? UzytkownikId { get; set; }
        /// <summary>
        /// Flaga, czy ma prawo podglądu danych z lokalizacji
        /// </summary>
        public int? Podglad { get; set; }
        /// <summary>
        /// Flaga, czy ma prawo edycji danych z lokalizacji
        /// </summary>
        public int? Edycja { get; set; }
        /// <summary>
        /// Kod CRC do weryfikacji poprawnosci wpisu
        /// </summary>
        public string Crc { get; set; }
        /// <summary>
        /// Flaga, czy zgoda na mailing
        /// </summary>
        public int? Mailing { get; set; }
    }
}
