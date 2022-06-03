using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Ograniczenia ładunków dla kontrahenta
    /// </summary>
    public partial class KontrahOgrLad
    {
        public int IdKontrahOgrLad { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int KontrahId { get; set; }
        /// <summary>
        /// Relacja do grupy ładunków - tab: GRUPY_LADUNKOW
        /// </summary>
        public int? GrupyLadunkowId { get; set; }
        /// <summary>
        /// Nazwa grupy ładunków
        /// </summary>
        public string GrupyLadunkow { get; set; }
        /// <summary>
        /// Algorytm, wg którego jest dokonywana kontrola ograniczeń ładunków
        /// </summary>
        public int? Algorytm { get; set; }
    }
}
