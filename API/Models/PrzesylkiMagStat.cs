using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Statystyka magazynowa przesyłek - detal do tabeli PRZESYLKI
    /// </summary>
    public partial class PrzesylkiMagStat
    {
        public int IdPrzesylkiMagStat { get; set; }
        /// <summary>
        /// Relacja do przesyłki - tab: PRZESYLKI
        /// </summary>
        public int? PrzesylkiId { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Ilość dni w magazynie
        /// </summary>
        public int? Dni { get; set; }
        /// <summary>
        /// Data od
        /// </summary>
        public DateTime? DataOd { get; set; }
        /// <summary>
        /// Data do
        /// </summary>
        public DateTime? DataDo { get; set; }
        /// <summary>
        /// Relacja do PZ - tab: MAGAZYN_ZDARZENIA
        /// </summary>
        public int? DokWejId { get; set; }
        /// <summary>
        /// Numer PZ
        /// </summary>
        public string DokWej { get; set; }
        /// <summary>
        /// Relacja do WZ - tab: MAGAZYN_ZDARZENIA
        /// </summary>
        public int? DokWyjId { get; set; }
        /// <summary>
        /// Numer WZ
        /// </summary>
        public string DokWyj { get; set; }
    }
}
