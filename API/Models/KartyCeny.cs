using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Definicje własnych cen paliwa dla kart paliwowych
    /// </summary>
    public partial class KartyCeny
    {
        public int IdKartyCeny { get; set; }
        /// <summary>
        /// Relacja do wydawcy karty - tab: KARTY_WYDAWCY
        /// </summary>
        public int? KartyWydawcyId { get; set; }
        /// <summary>
        /// Cena ważna od dnia
        /// </summary>
        public DateTime? DataOd { get; set; }
        /// <summary>
        /// Cena za 1 litr
        /// </summary>
        public double? Cena { get; set; }
        /// <summary>
        /// Waluta
        /// </summary>
        public string Waluta { get; set; }
    }
}
