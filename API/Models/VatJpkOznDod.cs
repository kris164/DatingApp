using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class VatJpkOznDod
    {
        public int IdVatJpkOznDod { get; set; }
        public string Kod { get; set; }
        public string Opis { get; set; }
        public int? Aktywny { get; set; }
        public int? TypDok { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
        public int? Sprzedaz { get; set; }
        public int? Koszt { get; set; }
    }
}
