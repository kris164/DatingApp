using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik pozycji fakturowych
    /// </summary>
    public partial class PozycjeFaktur
    {
        public int IdPozycjeFaktur { get; set; }
        /// <summary>
        /// Lp
        /// </summary>
        public int? Lp { get; set; }
        /// <summary>
        /// Tytuł pozycji
        /// </summary>
        public string Tytul { get; set; }
        /// <summary>
        /// Szablon do tworzenia opisu na fakturze
        /// </summary>
        public string SzablonDoOpis { get; set; }
        /// <summary>
        /// Etykiety dla szablonu
        /// </summary>
        public string EtykSzablonDoOpis { get; set; }
        /// <summary>
        /// Jednostka miary
        /// </summary>
        public string Jm { get; set; }
        /// <summary>
        /// PKWiU
        /// </summary>
        public string Pkwiu { get; set; }
        /// <summary>
        /// Kod stawki VAT - tab: STAWKI_VAT
        /// </summary>
        public string VatId { get; set; }
        /// <summary>
        /// Stawka VAT
        /// </summary>
        public double? Vat { get; set; }
        /// <summary>
        /// Cena jednostkowa
        /// </summary>
        public double? CenaJedn { get; set; }
        /// <summary>
        /// Rodzaj przychodu - tab: RODZ_PRZYCHODOW
        /// </summary>
        public string RodzPrzychodow { get; set; }
        /// <summary>
        /// Konto FK - sprzedaż
        /// </summary>
        public string KontoSprzedaz { get; set; }
        /// <summary>
        /// Rodzaj kosztu - tab: RODZ_KOSZTOW
        /// </summary>
        public string RodzKosztow { get; set; }
        /// <summary>
        /// Konto FK - zakupy
        /// </summary>
        public string KontoZakup { get; set; }
        /// <summary>
        /// Kod pozycji
        /// </summary>
        public string KodPozycji { get; set; }
        /// <summary>
        /// Flaga, czy pozycja dotyczy sprzedaży
        /// </summary>
        public int? Sprzedaz { get; set; }
        /// <summary>
        /// Flaga, czy pozycja dotyczy zakupów
        /// </summary>
        public int? Zakup { get; set; }
        /// <summary>
        /// Cena jednostkowa brutto
        /// </summary>
        public double? CenaJednB { get; set; }
        /// <summary>
        /// Waluta ceny jednostkowej
        /// </summary>
        public string CenaJednWal { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Dział
        /// </summary>
        public string Dzial { get; set; }
        /// <summary>
        /// Grupa pojazdów
        /// </summary>
        public string GrupaPoj { get; set; }
        /// <summary>
        /// Konto FK - rezerwy sprzedaży
        /// </summary>
        public string KontoSpRezerw { get; set; }
        /// <summary>
        /// Konto FK - rezerwy zakupu
        /// </summary>
        public string KontoZaRezerw { get; set; }
        /// <summary>
        /// Flaga, czy pozycja dotyczy not księgowych
        /// </summary>
        public int? Nota { get; set; }
        /// <summary>
        /// Flaga, czy pozycja dotyczy rezerw
        /// </summary>
        public int? Rezerwa { get; set; }
        /// <summary>
        /// Flaga, czy pozycja jest aktywna
        /// </summary>
        public int? Aktywna { get; set; }
        /// <summary>
        /// Flaga, czy pozycja zależna od kontenerów morskich
        /// </summary>
        public int? ZalOdKontenera { get; set; }
        /// <summary>
        /// Grupa analityczna
        /// </summary>
        public string GrupaAnalityczna { get; set; }
        /// <summary>
        /// Flaga, czy traktować pozycje przychdu jak fracht
        /// </summary>
        public int? PrzychJakFracht { get; set; }
        /// <summary>
        /// Flaga, czy traktować pozycje kosztu jak fracht
        /// </summary>
        public int? KosztJakFracht { get; set; }
        /// <summary>
        /// Flaga, czy pozycja dotyczy rozl. wewn.
        /// </summary>
        public int? RozlWewn { get; set; }
        /// <summary>
        /// Flaga, czy pozycja dotyczy zlec. FTL
        /// </summary>
        public int? ZlecFtl { get; set; }
        /// <summary>
        /// Flaga, czy pozycja dotyczy zlec. drobn.
        /// </summary>
        public int? Drobn { get; set; }
        /// <summary>
        /// Flaga, czy pozycja dotyczy zlec. kolej.
        /// </summary>
        public int? Kolej { get; set; }
        /// <summary>
        /// Flaga, czy pozycja dotyczy zlec. morskich
        /// </summary>
        public int? Morskie { get; set; }
        /// <summary>
        /// Flaga, czy pozycja dotyczy zlec. lotniczych
        /// </summary>
        public int? Lotnicze { get; set; }
        public string JezykPozycji { get; set; }
        /// <summary>
        /// Flaga, czy wyłaczyć na fakturach
        /// </summary>
        public int? WylFaktury { get; set; }
        /// <summary>
        /// Flaga, czy pozycja dotyczy promów
        /// </summary>
        public int? Promy { get; set; }
        /// <summary>
        /// Flaga, czy pozycja dotyczy zleceń celnych
        /// </summary>
        public int? Celne { get; set; }
        public string KontoFk { get; set; }
        /// <summary>
        /// Flaga, czy pozycja dotyczy prowizji interlanowych
        /// </summary>
        public int? IntOrders { get; set; }
        public int? FSystemPozId { get; set; }
        public string Kategoria { get; set; }
        public int? SplitPaymentS { get; set; }
        public int? VatJpkOznId { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
        /// <summary>
        /// Flaga, czy pozycja dotyczy godzin do rozliczenia
        /// </summary>
        public int? IntOrdersHours { get; set; }
    }
}
