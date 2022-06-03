using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class AdrZestawyWyp
    {
        public int IdAdrZestawyWyp { get; set; }
        public string Oznaczenie { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
