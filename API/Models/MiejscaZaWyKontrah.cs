using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Relacje POI-ów do Kontrahentów (detal do MIEJSCA_ZA_ROZLADUNKU)
    /// </summary>
    public partial class MiejscaZaWyKontrah
    {
        public int IdMiejscaZaWyKontrah { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab.: KONTRAHENCI
        /// </summary>
        public int? KlientId { get; set; }
        /// <summary>
        /// Symbol kontrahenta
        /// </summary>
        public string Klient { get; set; }
        /// <summary>
        /// Relacja do POI-a - tab.: MIEJSCA_ZA_ROZLADUNKU
        /// </summary>
        public int? MiejscaZaRozladunkuId { get; set; }
        /// <summary>
        /// Domyślny
        /// </summary>
        public int? Domyslny { get; set; }
    }
}
