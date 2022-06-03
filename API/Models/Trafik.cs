using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Trafik
    {
        public int IdTrafik { get; set; }
        public string Kod { get; set; }
        public string KodLiczn { get; set; }
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
        public string Opis { get; set; }
        public int? WlLicznik { get; set; }
        public int? Licznik { get; set; }
        public int? Aktywny { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
