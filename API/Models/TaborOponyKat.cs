using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Przypisanie opony do kategorii
    /// </summary>
    public partial class TaborOponyKat
    {
        public int IdTaborOponyKat { get; set; }
        /// <summary>
        /// Relacja do opony - tab: TABOR_OPONY
        /// </summary>
        public int? TaborOponyId { get; set; }
        /// <summary>
        /// Relacja do kategorii - tab: KATEGORIE - TYP=KO
        /// </summary>
        public int? KatId { get; set; }
    }
}
