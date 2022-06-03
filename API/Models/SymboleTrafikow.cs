using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik symboli trafików
    /// </summary>
    public partial class SymboleTrafikow
    {
        public int IdSymboleTrafikow { get; set; }
        /// <summary>
        /// Symbol trafiku
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// Opis
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Kraj
        /// </summary>
        public string Kraj { get; set; }
        /// <summary>
        /// Flaga, czy każda paczka z tego trafiku jest identyfikowalna
        /// </summary>
        public int? IdentPaczki { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
