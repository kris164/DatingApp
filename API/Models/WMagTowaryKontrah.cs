using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WMagTowaryKontrah
    {
        public int IdWMagTowaryKontrah { get; set; }
        public int WMagTowaryId { get; set; }
        public int KontrahId { get; set; }
        public string KontrahSymbol { get; set; }
        public string SymbolTowaru { get; set; }
    }
}
