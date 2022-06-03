using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Prawa użytkowników do typów blokad obiektów systemowych
    /// </summary>
    public partial class BlokadyTypyPrawa
    {
        public int IdBlokadyTypyPrawa { get; set; }
        /// <summary>
        /// Relacja do BLOKADY_TYPY
        /// </summary>
        public int BlokadyTypyId { get; set; }
        /// <summary>
        /// Relacja do użytkownika - tab: UZYTKOWNIK
        /// </summary>
        public int UzytkownikId { get; set; }
        /// <summary>
        /// Flaga, czy ma prawo założyć
        /// </summary>
        public int MozeZalozyc { get; set; }
        /// <summary>
        /// Flaga, czy ma prawo zdjąć
        /// </summary>
        public int MozeZdjac { get; set; }
        /// <summary>
        /// Flaga, czy ma prawo przepuścić
        /// </summary>
        public int MozePuscic { get; set; }
        /// <summary>
        /// Kod CRC do weryfikacji poprawnosci wpisu
        /// </summary>
        public string Crc { get; set; }
    }
}
