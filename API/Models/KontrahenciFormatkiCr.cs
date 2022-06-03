using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Ind formatki CR kontrahenta w podziale na działy
    /// </summary>
    public partial class KontrahenciFormatkiCr
    {
        public int IdKontrahenciFormatkiCr { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int KontrahId { get; set; }
        /// <summary>
        /// Dotyczy lokalizacji lub *
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Dotyczy działu lub *
        /// </summary>
        public string Dzial { get; set; }
        public string SysFormatkaCr { get; set; }
        public string IndFormatkaCr { get; set; }
    }
}
