using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik rodzajów przychodów
    /// </summary>
    public partial class RodzPrzychodow
    {
        public int IdRodzPrzychodow { get; set; }
        /// <summary>
        /// Kod
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// Lp
        /// </summary>
        public int? Lp { get; set; }
        /// <summary>
        /// Opis
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Konto FK
        /// </summary>
        public string Konto { get; set; }
        /// <summary>
        /// Wyróżnik 1
        /// </summary>
        public string Wyroznik { get; set; }
        /// <summary>
        /// Konto rezerw
        /// </summary>
        public string KontoRezerw { get; set; }
        /// <summary>
        /// Wyróżnik 2
        /// </summary>
        public string Wyroznik1 { get; set; }
        /// <summary>
        /// Grupa rodzaju przychodu
        /// </summary>
        public string Grupa { get; set; }
        /// <summary>
        /// Flaga, czy usługa
        /// </summary>
        public int? Usluga { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
