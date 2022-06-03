using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Przypisanie taboru do kategorii
    /// </summary>
    public partial class TaborKat
    {
        public int IdTaborKat { get; set; }
        /// <summary>
        /// Relacja do pojazdu - tab: TABOR
        /// </summary>
        public int? TaborId { get; set; }
        /// <summary>
        /// Relacja do kategorii - tab: KATEGORIE - TYP=TA
        /// </summary>
        public int? KatId { get; set; }
    }
}
