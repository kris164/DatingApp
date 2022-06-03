using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class AdrKodyPojazdow
    {
        public int IdAdrKodyPojazdow { get; set; }
        public int Lp { get; set; }
        public string Kod { get; set; }
        public string TypyPojazdow { get; set; }
        public string Opis { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
