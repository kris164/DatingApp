using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Wyłaczenia czasowe dla POI-a (detal do MIEJSCA_ZA_ROZLADUNKU)
    /// </summary>
    public partial class MiejscaZaWyWylacz
    {
        public int IdMiejscaZaWyWylacz { get; set; }
        /// <summary>
        /// Relacja do POI-a - tab.: MIEJSCA_ZA_ROZLADUNKU
        /// </summary>
        public int? MiejscaZaRozladunkuId { get; set; }
        /// <summary>
        /// Data od
        /// </summary>
        public DateTime? DataOd { get; set; }
        /// <summary>
        /// Data do
        /// </summary>
        public DateTime? DataDo { get; set; }
        /// <summary>
        /// Opis
        /// </summary>
        public string Info { get; set; }
    }
}
