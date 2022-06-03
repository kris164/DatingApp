using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Historia blokad kontrahentów
    /// </summary>
    public partial class KontrahenciBlokady
    {
        public int IdKontrahenciBlokady { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int KontrahId { get; set; }
        public string Uzytkownik { get; set; }
        public int UzytkownikId { get; set; }
        /// <summary>
        /// 1 - blokada, 0 - odblokowanie
        /// </summary>
        public int Typ { get; set; }
        /// <summary>
        /// Data/Godz zablokowania/odblokowania
        /// </summary>
        public DateTime CzasZdarzenia { get; set; }
        public string Powod { get; set; }
    }
}
