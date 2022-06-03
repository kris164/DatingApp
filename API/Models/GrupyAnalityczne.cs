using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik grup analitycznych
    /// </summary>
    public partial class GrupyAnalityczne
    {
        public int IdGrupyAnalityczne { get; set; }
        /// <summary>
        /// Kod
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// Opis
        /// </summary>
        public string Opis { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
