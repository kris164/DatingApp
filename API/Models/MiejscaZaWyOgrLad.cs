using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Ograniczenia ładunków dla POI
    /// </summary>
    public partial class MiejscaZaWyOgrLad
    {
        public int IdMiejscaZaWyOgrLad { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: MIEJSCA_ZA_ROZLADUNKU
        /// </summary>
        public int MiejscaZaRozladunkuId { get; set; }
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
