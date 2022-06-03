using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// rejestracja zdarzeń z przystawki mocy pojazdu
    /// </summary>
    public partial class SfmPto
    {
        public int IdSfmPto { get; set; }
        /// <summary>
        /// id taboru SPEED
        /// </summary>
        public int? IdTabor { get; set; }
        /// <summary>
        /// id terminala
        /// </summary>
        public int? IdSfmTerm { get; set; }
        /// <summary>
        /// id początkowej pozycji GPS
        /// </summary>
        public int? IdSfmPosStart { get; set; }
        /// <summary>
        /// id końcowej pozycji GPS
        /// </summary>
        public int? IdSfmPosStop { get; set; }
        /// <summary>
        /// PTO_ID
        /// </summary>
        public string Pto { get; set; }
        /// <summary>
        /// czas utworzenia / zapisu do BD
        /// </summary>
        public DateTime? DtSave { get; set; }
        /// <summary>
        /// czas początku aktywności
        /// </summary>
        public DateTime? DtStart { get; set; }
        /// <summary>
        /// czas końca aktywności
        /// </summary>
        public DateTime? DtStop { get; set; }
    }
}
