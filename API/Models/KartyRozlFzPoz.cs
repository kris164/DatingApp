using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Pozycje rozliczenia faktur zbiorczych
    /// </summary>
    public partial class KartyRozlFzPoz
    {
        public int IdKartyRozlFzPoz { get; set; }
        /// <summary>
        /// Relacja do nagłówka rozliczenia - tab: KARTY_ROZL_FZ
        /// </summary>
        public int? KartyRozlFzId { get; set; }
        /// <summary>
        /// Identyfikator WZ (dowolny identyfikator klienta)
        /// </summary>
        public int? WzId { get; set; }
        /// <summary>
        /// Status rozl: 0- zgodne, 1 - niezgodna kwota, 2 - niezgodna ilość, 3 - niezgodna data
        /// </summary>
        public int? Status { get; set; }
    }
}
