using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Ograniczenia ładunków dla kontrahenta - pozycje
    /// </summary>
    public partial class KontrahOgrLadPoz
    {
        public int IdKontrahOgrLadPoz { get; set; }
        /// <summary>
        /// Relacja do nagłówka ograniczeń - tab: KONTRAH_OGR_LAD
        /// </summary>
        public int KontrahOgrLadId { get; set; }
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
    }
}
