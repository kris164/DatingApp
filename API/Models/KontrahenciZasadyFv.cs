using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class KontrahenciZasadyFv
    {
        public int IdKontrahenciZasadyFv { get; set; }
        public string Nazwa { get; set; }
        public int? Zbiorcza { get; set; }
        public int? Widoczny { get; set; }
        public string Symbol { get; set; }
        public string GrupowanieZb { get; set; }
        public string FormatkaCr { get; set; }
        public string FormatkaKorCr { get; set; }
        public string FormatkaNotaCr { get; set; }
        public string FormatkaNotaKorCr { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
