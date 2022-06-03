using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Ograniczenia ładunków dla POI - pozycje
    /// </summary>
    public partial class MiejscaZaWyOgrLadPoz
    {
        public int IdMiejscaZaWyOgrLadPoz { get; set; }
        /// <summary>
        /// Relacja do nagłówka ograniczeń - tab: MIEJSCA_ZA_WY_OGR_LAD
        /// </summary>
        public int MiejscaZaWyOgrLadId { get; set; }
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
    }
}
