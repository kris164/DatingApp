using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Typy blokad obiektów systemowych
    /// </summary>
    public partial class BlokadyTypy
    {
        public int IdBlokadyTypy { get; set; }
        /// <summary>
        /// Kod blokady
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// Czy aktywny/widoczny
        /// </summary>
        public int Aktywny { get; set; }
        /// <summary>
        /// Czy systemowy
        /// </summary>
        public int Systemowy { get; set; }
        /// <summary>
        /// Opis
        /// </summary>
        public string Opis { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
