using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WMagPrzyjeciaPoz
    {
        public int IdWMagPrzyjeciaPoz { get; set; }
        public int? WMagPrzyjeciaId { get; set; }
        public int? WMagTowaryId { get; set; }
        public string WMagTowary { get; set; }
        public string SymbolTowaru { get; set; }
        public int? Lp { get; set; }
        public double? Ilosc { get; set; }
        public double? CenaJednN { get; set; }
        public string StawkaVatId { get; set; }
        public double? StawkaVat { get; set; }
        public double? WartoscZakupuN { get; set; }
        public double? WartoscZakupuV { get; set; }
        public double? WartoscZakupuB { get; set; }
        public string Status { get; set; }
        public string Magazyn { get; set; }
        public double? Wydano { get; set; }
        public int? Opona { get; set; }
        public double? IloscP { get; set; }
        public string JmP { get; set; }
        public double? CenaJednNP { get; set; }
        public double? Przelicznik { get; set; }
        public string Jm { get; set; }
        public int? WFakturaKId { get; set; }
        public int? KorektaDoPzPozId { get; set; }
        public double? Rezerwacje { get; set; }
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
        public string KorektaJmP { get; set; }
        public double? KorektaIloscP { get; set; }
        public double? KorektaCenaJednNP { get; set; }
        public double? KorektaCenaJednN { get; set; }
        public double? KorektaWartoscZakupuN { get; set; }
        public double? KorektaWartoscZakupuV { get; set; }
        public double? KorektaWartoscZakupuB { get; set; }
        public string KorektaStawkaVatId { get; set; }
        public double? KorektaStawkaVat { get; set; }
        public int? FakturyPozycjeId { get; set; }
        public double? KorektaCenaJednP { get; set; }
        public double? PrzedKorIloscP { get; set; }
        public string PrzedKorJmP { get; set; }
        public double? PrzedKorCenaJednNP { get; set; }
        public double? PrzedKorCenaJednN { get; set; }
        public double? PrzedKorWartoscZakupuN { get; set; }
        public double? PrzedKorWartoscZakupuV { get; set; }
        public double? PrzedKorWartoscZakupuB { get; set; }
        public string PrzydzialKosztu { get; set; }
    }
}
