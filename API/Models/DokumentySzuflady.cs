using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik szuflad na dokumenty ROD
    /// </summary>
    public partial class DokumentySzuflady
    {
        public int IdDokumentySzuflady { get; set; }
        /// <summary>
        /// Kod pozycji
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
