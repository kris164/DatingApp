using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WMagZamowieniaPoz
    {
        public int IdWMagZamowieniaPoz { get; set; }
        public int WMagZamowieniaId { get; set; }
        public int WMagTowaryId { get; set; }
        public string Magazyn { get; set; }
        public int Lp { get; set; }
        public string SymbolTowaru { get; set; }
        public string SymbolDostawcy { get; set; }
        public int? Opona { get; set; }
        public double? IloscP { get; set; }
        public string JmP { get; set; }
        public double? CenaJednNP { get; set; }
        public double? Przelicznik { get; set; }
        public double? Ilosc { get; set; }
        public string Jm { get; set; }
        public double? CenaJednN { get; set; }
        public string StawkaVatId { get; set; }
        public double? StawkaVat { get; set; }
        public double? WartoscZakupuN { get; set; }
        public double? WartoscZakupuV { get; set; }
        public double? WartoscZakupuB { get; set; }
        public int? PzPozId { get; set; }
        public int? FakturaPozId { get; set; }
    }
}
