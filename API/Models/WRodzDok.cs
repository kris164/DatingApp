using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WRodzDok
    {
        public int IdWRodzDok { get; set; }
        public int? Lp { get; set; }
        public string Nazwa { get; set; }
        public string Kierunek { get; set; }
        public string SymbolLicznika { get; set; }
        public string SymbolFk { get; set; }
        public string KontoFk { get; set; }
        public int? Aktywny { get; set; }
        public int? Systemowy { get; set; }
        public int? TypDokumentu { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
