using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WMagWydaniaPoz
    {
        public int IdWMagWydaniaPoz { get; set; }
        public int? WMagWydaniaId { get; set; }
        public int? WMagTowaryId { get; set; }
        public string WMagTowary { get; set; }
        public string SymbolTowaru { get; set; }
        public int? Lp { get; set; }
        public double? Ilosc { get; set; }
        public double? CenaJednN { get; set; }
        public string StawkaVatId { get; set; }
        public double? StawkaVat { get; set; }
        public double? WartoscWydaniaN { get; set; }
        public double? WartoscWydaniaV { get; set; }
        public double? WartoscWydaniaB { get; set; }
        public string Status { get; set; }
        public string Magazyn { get; set; }
        public int? Opona { get; set; }
        public int? DopiszDoWypPoj { get; set; }
        public int? MagObcyFaktPozId { get; set; }
        public int? MagObcyFaktId { get; set; }
        public string MagObcyFakt { get; set; }
        public int? WMagPrzyjeciaPozId { get; set; }
        public int? WMagKorektaPozId { get; set; }
        public double? PrzedKorIlosc { get; set; }
        public double? PrzedKorCena { get; set; }
        public string PrzedKorJm { get; set; }
        public double? PrzedKorCenap { get; set; }
        public double? PrzedKorPrzelicznik { get; set; }
        public double? KorektaIlosc { get; set; }
        public double? KorektaCena { get; set; }
        public string KorektaJm { get; set; }
        public double? KorektaCenap { get; set; }
        public double? KorektaPrzelicznik { get; set; }
        public string Jm { get; set; }
        public int? WZleceniaPozId { get; set; }
        public int? FakturyPozycjeId { get; set; }
        public int? WFakturaKId { get; set; }
        public int? KorektaDoWzPozId { get; set; }
        public double? PrzedKorWartoscZakupuN { get; set; }
        public double? PrzedKorWartosc { get; set; }
        public double? KorektaWartosc { get; set; }
        public int? ExtStatus1 { get; set; }
        public string PrzydzialKosztu { get; set; }
        public double? PrzedKorWartoscV { get; set; }
        public double? KorektaWartoscV { get; set; }
        public double? PrzedKorWartoscB { get; set; }
        public double? KorektaWartoscB { get; set; }
        public int? DopiszDoWypPrac { get; set; }
    }
}
