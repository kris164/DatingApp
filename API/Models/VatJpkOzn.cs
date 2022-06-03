using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class VatJpkOzn
    {
        public int IdVatJpkOzn { get; set; }
        public string Kod { get; set; }
        public string Opis { get; set; }
        public int Aktywny { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
