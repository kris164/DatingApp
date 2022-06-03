using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WZleceniaPoz
    {
        public int IdWZleceniaPoz { get; set; }
        public int? WZlecenieId { get; set; }
        public string WMagWydania { get; set; }
        public int? WMagWydaniaId { get; set; }
        public int? WMagWydaniaPozId { get; set; }
        public int? Lp { get; set; }
        public string Typ { get; set; }
        public string Magazyn { get; set; }
        public int? ObjId { get; set; }
        public int? WMagTowaryId { get; set; }
        public string SymbolTowaru { get; set; }
        public string Nazwa1 { get; set; }
        public string Nazwa2 { get; set; }
        public string Jm { get; set; }
        public string Pkwiu { get; set; }
        public string Grupa { get; set; }
        public string Producent { get; set; }
        public double? Ilosc { get; set; }
        public double? CenaJednN { get; set; }
        public string StawkaVatId { get; set; }
        public double? StawkaVat { get; set; }
        public double? WartoscN { get; set; }
        public double? WartoscV { get; set; }
        public double? WartoscB { get; set; }
        public string NrFakturyZakupu { get; set; }
        public string Dostawca { get; set; }
        public double? NormaCzasowa { get; set; }
        public string RodzKosztow { get; set; }
        public string WPracownicy { get; set; }
        public int? Opona { get; set; }
        public int? Opony { get; set; }
        public int? OponyId { get; set; }
        public string OponyTypObsl { get; set; }
        public int? OponyNrOsi { get; set; }
        public string OponyStrona { get; set; }
        public string OpisDod { get; set; }
        public double? Nadg50 { get; set; }
        public double? Nadg100 { get; set; }
        public int? WMagPrzyjeciaPozId { get; set; }
        public int? Zalaczniki { get; set; }
        /// <summary>
        /// Relacja do użytkownika tworzącego rekord - tab: UZYTKOWNIK
        /// </summary>
        public int? CreateIdUser { get; set; }
        /// <summary>
        /// Nazwa użytkownika tworzącego rekord
        /// </summary>
        public string CreateUserName { get; set; }
        /// <summary>
        /// Data utworzenia
        /// </summary>
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// Godzina utworzenia
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// Relacja do użytkownika który ostatni modyfikował rekord - tab: UZYTKOWNIK
        /// </summary>
        public int? ModifyIdUser { get; set; }
        /// <summary>
        /// Nazwa użytkownika modyfikującego rekord
        /// </summary>
        public string ModifyUserName { get; set; }
        /// <summary>
        /// Data ostatniej modyfikacji
        /// </summary>
        public DateTime? ModifyDate { get; set; }
        /// <summary>
        /// Godzina ostatniej modyfikacji
        /// </summary>
        public DateTime? ModifyTime { get; set; }
        public double? Marza { get; set; }
        public double? CenaJednNM { get; set; }
        public double? WartoscNM { get; set; }
        public double? WartoscVM { get; set; }
        public double? WartoscBM { get; set; }
        public double? StalaCenaSprzedazy { get; set; }
        public double? StalaCenaSprzedazyN { get; set; }
        public double? MarzaKwota { get; set; }
        public int? WFakturaId { get; set; }
        public int? MagObcy { get; set; }
        public double? Rabat { get; set; }
        public string Waluta { get; set; }
        public int? WFakturaKId { get; set; }
        public string ZleceniaTyp { get; set; }
        public int? ZleceniaId { get; set; }
        public string Zlecenia { get; set; }
        public int? SzkodyId { get; set; }
        public string Szkody { get; set; }
        public int? WDaneZewnWzPozId { get; set; }
        /// <summary>
        /// Dodano do wykorz. przez ZleceniaWydanieMagWiz mw
        /// </summary>
        public int? DopiszDoWypPoj { get; set; }
        public int? FakturyPozycjeId { get; set; }
        public int? CenaUzytkownika { get; set; }
        public int? KorektaWz { get; set; }
        public decimal? PrzedKorIlosc { get; set; }
        public double? PrzedKorCenaJednN { get; set; }
        public string PrzedKorStawkaVatId { get; set; }
        public double? PrzedKorStawkaVat { get; set; }
        public double? PrzedKorWartoscN { get; set; }
        public double? PrzedKorWartoscV { get; set; }
        public double? PrzedKorWartoscB { get; set; }
        public double? PrzedKorCenaJednNM { get; set; }
        public double? PrzedKorWartoscNM { get; set; }
        public double? PrzedKorWartoscVM { get; set; }
        public double? PrzedKorWartoscBM { get; set; }
        public string KorWMagWydania { get; set; }
        public int? KorWMagWydaniaId { get; set; }
        public int? KorWMagWydaniaPozId { get; set; }
        public string PrzydzialKosztu { get; set; }
        public string NrKatalog { get; set; }
        public string Ref1 { get; set; }
        public double? Narzut { get; set; }
        public int? CenaZaUsluge { get; set; }
        public int? DopiszDoWypPrac { get; set; }
        public string StawkaVatZakId { get; set; }
        public double? StawkaVatZak { get; set; }
    }
}
