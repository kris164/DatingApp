using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Pozycje pliku z transakcjami kart paliwowych
    /// </summary>
    public partial class KartyTransakcje
    {
        public int IdKartyTransakcje { get; set; }
        /// <summary>
        /// Relacja do nagłówka pliku - tab: KARTA_PLIKI
        /// </summary>
        public int? KartaPlikiId { get; set; }
        /// <summary>
        /// Data transakcji
        /// </summary>
        public DateTime? DataTransakcji { get; set; }
        /// <summary>
        /// Godz. transakcji
        /// </summary>
        public DateTime? CzasTransakcji { get; set; }
        /// <summary>
        /// Identyfikator transakcji
        /// </summary>
        public string IdTransakcji { get; set; }
        /// <summary>
        /// Opis transakcji
        /// </summary>
        public string OpisTransakcji { get; set; }
        /// <summary>
        /// Relacja do karty paliwowej - tab: KARTY
        /// </summary>
        public int? KartaId { get; set; }
        /// <summary>
        /// Numer karty paliwowej
        /// </summary>
        public string Karta { get; set; }
        /// <summary>
        /// Relacja do pojazdu - tab: TABOR
        /// </summary>
        public int? TaborId { get; set; }
        /// <summary>
        /// Numer rejestracyjny pojazdu
        /// </summary>
        public string Tabor { get; set; }
        /// <summary>
        /// Relacja do polecenia wyjazdu - tab: WYJAZDY
        /// </summary>
        public int? WyjazdId { get; set; }
        /// <summary>
        /// Numer polecenia wyjazdu
        /// </summary>
        public string Wyjazd { get; set; }
        /// <summary>
        /// Relacja do delegacji pracownika - tab: DELEGACJE
        /// </summary>
        public int? DelegacjaId { get; set; }
        /// <summary>
        /// Numer delegacji pracownika
        /// </summary>
        public string Delegacja { get; set; }
        /// <summary>
        /// Rodzaj transakcji
        /// </summary>
        public string RodzajTrans { get; set; }
        /// <summary>
        /// Rodzaj kosztów
        /// </summary>
        public string RodzKosztow { get; set; }
        /// <summary>
        /// Kraj kosztów
        /// </summary>
        public string KrajKosztow { get; set; }
        /// <summary>
        /// Ilość transakcji
        /// </summary>
        public double? Ilosc { get; set; }
        /// <summary>
        /// Waluta transakcji
        /// </summary>
        public string Waluta { get; set; }
        /// <summary>
        /// Kwota w walucie bez upustu
        /// </summary>
        public double? KwotaWWalBezUp { get; set; }
        /// <summary>
        /// Kwota w walucie
        /// </summary>
        public double? KwotaWWal { get; set; }
        /// <summary>
        /// Kwota w PLN bez upustu
        /// </summary>
        public double? KwotaWPlnBezUp { get; set; }
        /// <summary>
        /// Kwota w PLN
        /// </summary>
        public double? KwotaWPln { get; set; }
        /// <summary>
        /// Stawka VAT dla transakcji
        /// </summary>
        public double? StawkaVat { get; set; }
        /// <summary>
        /// Kwota VAT transakcji
        /// </summary>
        public double? KwotaVat { get; set; }
        /// <summary>
        /// Kwota netto bez upustu
        /// </summary>
        public double? KwotaNettoBezUp { get; set; }
        /// <summary>
        /// Kwota netto transakcji
        /// </summary>
        public double? KwotaNetto { get; set; }
        /// <summary>
        /// Status transakcji
        /// </summary>
        public int? Status { get; set; }
        /// <summary>
        /// Relacja do faktury dekretujacej - tab: FAKTURY
        /// </summary>
        public int? FakturaId { get; set; }
        /// <summary>
        /// Numer faktury dekretującej
        /// </summary>
        public string Faktura { get; set; }
        /// <summary>
        /// Numer dekretu
        /// </summary>
        public string Dekret { get; set; }
        /// <summary>
        /// Stan licznika pojazdu
        /// </summary>
        public double? Licznik { get; set; }
        /// <summary>
        /// Numer faktury z pliku
        /// </summary>
        public string PlikNrFaktury { get; set; }
        /// <summary>
        /// Data faktury z pliku
        /// </summary>
        public DateTime? PlikDataFaktury { get; set; }
        /// <summary>
        /// Znacznik, czy tankowanie do pełna
        /// </summary>
        public int? FullTank { get; set; }
        /// <summary>
        /// Numer boczny pojazdu
        /// </summary>
        public string TaborNrB { get; set; }
        /// <summary>
        /// Kwota oryginalna
        /// </summary>
        public double? KwotaOrg { get; set; }
        /// <summary>
        /// Waluta oryginalna
        /// </summary>
        public string WalutaOrg { get; set; }
        /// <summary>
        /// Kwota brutto transakcji
        /// </summary>
        public double? KwotaBrutto { get; set; }
        /// <summary>
        /// Relacja do zlecenia - tab: ZLECENIA
        /// </summary>
        public int? ZleceniaId { get; set; }
        /// <summary>
        /// Numer zlecenia
        /// </summary>
        public string Zlecenia { get; set; }
        /// <summary>
        /// Stawka VAT
        /// </summary>
        public string VatId { get; set; }
        /// <summary>
        /// Relacja do trasy - tab: LISTY_LINIOWE
        /// </summary>
        public int? ListyLinioweId { get; set; }
        /// <summary>
        /// Numer trasy
        /// </summary>
        public string ListyLiniowe { get; set; }
        /// <summary>
        /// Relacja do pozycji WZ z warsztatu
        /// </summary>
        public int? WMagWydaniaPozId { get; set; }
        /// <summary>
        /// Numer rejestracyjny pojazdu - pliku
        /// </summary>
        public string TaborOrg { get; set; }
        /// <summary>
        /// Relacja do transakcji GPS
        /// </summary>
        public int? SfmCostsId { get; set; }
        /// <summary>
        /// Numer stacji
        /// </summary>
        public string NrStacji { get; set; }
        /// <summary>
        /// Relacja do refaktury
        /// </summary>
        public int? RefakturyId { get; set; }
        /// <summary>
        /// Relacja do pozycji refaktury
        /// </summary>
        public int? RefakturyPozId { get; set; }
        /// <summary>
        /// Relacja do delegacji pracownika - tab: EF_KARTY
        /// </summary>
        public int? EfKartyId { get; set; }
        /// <summary>
        /// Numer KE
        /// </summary>
        public string EfKarty { get; set; }
        /// <summary>
        /// Numer własny
        /// </summary>
        public string NrSped { get; set; }
    }
}
