using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Okna czasowe dla POI-a (detal do MIEJSCA_ZA_ROZLADUNKU)
    /// </summary>
    public partial class MiejscaZaWyCza
    {
        public int IdMiejscaZaWyCzas { get; set; }
        /// <summary>
        /// Relacja do POI-a - tab.: MIEJSCA_ZA_ROZLADUNKU
        /// </summary>
        public int? MiejscaZaRozladunkuId { get; set; }
        /// <summary>
        /// Dzień tygodnia
        /// </summary>
        public int? DzienTyg { get; set; }
        /// <summary>
        /// Godz od
        /// </summary>
        public DateTime? GodzOd { get; set; }
        /// <summary>
        /// Godz do
        /// </summary>
        public DateTime? GodzDo { get; set; }
    }
}
