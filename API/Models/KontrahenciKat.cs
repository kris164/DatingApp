using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Przypisanie kontrahenta do kategorii
    /// </summary>
    public partial class KontrahenciKat
    {
        public int IdKontrahenciKat { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int? KontrahId { get; set; }
        /// <summary>
        /// Relacja do kategorii - tab: KATEGORIE - TYP=KO
        /// </summary>
        public int? KatId { get; set; }
        /// <summary>
        /// Uwagi
        /// </summary>
        public string Uwagi { get; set; }
    }
}
