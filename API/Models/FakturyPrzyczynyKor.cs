using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class FakturyPrzyczynyKor
    {
        public int IdFakturyPrzyczynyKor { get; set; }
        public string Opis { get; set; }
        /// <summary>
        /// 0 - możliwy, 1 - wymagany, 2 - niedozwolony
        /// </summary>
        public int? DodOpis { get; set; }
        /// <summary>
        /// Symbol używany w interfejsach do FK
        /// </summary>
        public string SymbolDoFk { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
