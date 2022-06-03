using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik procedur mycia
    /// </summary>
    public partial class PoiMyjnieProcedury
    {
        public int IdPoiMyjnieProcedury { get; set; }
        /// <summary>
        /// Kod
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// Opis 
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Czy mycie pełne
        /// </summary>
        public int? Pelne { get; set; }
        /// <summary>
        /// Czy mycie koszerne
        /// </summary>
        public int? Koszerne { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
