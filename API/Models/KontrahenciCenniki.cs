using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Cenniki kontrahenta
    /// </summary>
    public partial class KontrahenciCenniki
    {
        public int IdKontrahenciCenniki { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int? KontrahId { get; set; }
        /// <summary>
        /// Typ cennika KM-kilometrowy, T - tonowy
        /// </summary>
        public string Typ { get; set; }
        /// <summary>
        /// Data ważności od
        /// </summary>
        public DateTime? DataOd { get; set; }
        /// <summary>
        /// Stawka
        /// </summary>
        public double? Stawka { get; set; }
    }
}
