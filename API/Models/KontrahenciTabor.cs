using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Przypisanie kontrahenta do pojazdów
    /// </summary>
    public partial class KontrahenciTabor
    {
        public int IdKontrahenciTabor { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int? KontrahId { get; set; }
        /// <summary>
        /// Relacja do pojazdu - tab: TABOR
        /// </summary>
        public int? TaborId { get; set; }
    }
}
