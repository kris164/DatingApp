using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Powiązanie działó z lokalizacjami
    /// </summary>
    public partial class LokalizacjeDzialy
    {
        public int IdLokalizacjeDzialy { get; set; }
        /// <summary>
        /// Kod lokalizacji
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Relacja do lokalizacji - tab: LOKALIZACJE
        /// </summary>
        public int? LokalizacjaId { get; set; }
        /// <summary>
        /// Kod działu
        /// </summary>
        public string Dzial { get; set; }
        /// <summary>
        /// Relacja do działu - tab: DZIALY
        /// </summary>
        public int? DzialId { get; set; }
    }
}
