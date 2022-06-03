using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WMagInwentPoz
    {
        public int IdWMagInwentPoz { get; set; }
        public int? WMagInwentId { get; set; }
        public string Status { get; set; }
        public int? WMagTowaryId { get; set; }
        public string SymbolTowaru { get; set; }
        public int? Lp { get; set; }
        public string Nazwa1 { get; set; }
        public string Nazwa2 { get; set; }
        public string Jm { get; set; }
        public string Pkwiu { get; set; }
        public string Grupa { get; set; }
        public string Producent { get; set; }
        public double? Ilosc { get; set; }
        public double? IloscSpis { get; set; }
        public double? Roznica { get; set; }
        public double? CenaJednN { get; set; }
        public string Lokalizacja { get; set; }
        public int? WMagWydaniaPozId { get; set; }
        public int? WMagPrzyjeciaPozId { get; set; }
        public string Dzial { get; set; }
        public string NrKatalog { get; set; }
        public string Ref1 { get; set; }
        public string Dostawca { get; set; }
        public string KodKreskowy { get; set; }
    }
}
