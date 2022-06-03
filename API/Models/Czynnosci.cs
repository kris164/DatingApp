using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Czynnosci
    {
        public int IdCzynnosci { get; set; }
        public string Kod { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public string Wskaznik { get; set; }
        public int? Interwal { get; set; }
        public int? BlokPrzekr { get; set; }
        public int? BlokPrzekrO { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
        public int? Visible { get; set; }
    }
}
