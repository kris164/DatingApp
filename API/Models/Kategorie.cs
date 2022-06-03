using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik kategorii
    /// </summary>
    public partial class Kategorie
    {
        public int IdKategorie { get; set; }
        /// <summary>
        /// Typ kategorii KO - kontrahenci, KI - kierowcy, TA - tabor
        /// </summary>
        public string Typ { get; set; }
        /// <summary>
        /// Nazwa kategorii
        /// </summary>
        public string Nazwa { get; set; }
        /// <summary>
        /// Opis kategorii
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Flaga, czy aktywna
        /// </summary>
        public int Aktywna { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
