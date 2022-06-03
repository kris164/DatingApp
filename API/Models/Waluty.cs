using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Waluty
    {
        public string Kod { get; set; }
        public int? Symbol { get; set; }
        public string Nazwa { get; set; }
        public short? KursNa { get; set; }
        public string KrajKod { get; set; }
        public short? Widoczny { get; set; }
        public short? WUzyciu { get; set; }
        public short? KursTyp { get; set; }
        public string SymbolDoFk { get; set; }
        public string SymbolDoFk2 { get; set; }
        public string SymbolDoFk3 { get; set; }
        public short? UzywajWLicznSzcz { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
