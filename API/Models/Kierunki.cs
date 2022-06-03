using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik kierunków
    /// </summary>
    public partial class Kierunki
    {
        public int IdKierunki { get; set; }
        /// <summary>
        /// Kod kierunku np. IMP, EXP etc
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// Opis kierunku
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Symbol na potrzeby liczników systemowych
        /// </summary>
        public string SymbolLiczniki { get; set; }
        public short? Widoczny { get; set; }
        public string SymbolFk { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
