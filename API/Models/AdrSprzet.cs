using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class AdrSprzet
    {
        public int IdAdrSprzet { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
