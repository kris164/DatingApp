using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Jakie ładunki kontrahent zleca
    /// </summary>
    public partial class KontrahLadunki
    {
        public int IdKontrahLadunki { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int KontrahId { get; set; }
        /// <summary>
        /// Relacja do tabeli ładunków - tab: OPISY_TOWAROW
        /// </summary>
        public int? OpisyTowarowId { get; set; }
        /// <summary>
        /// Nazwa towaru
        /// </summary>
        public string OpisyTowarow { get; set; }
    }
}
