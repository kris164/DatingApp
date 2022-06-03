using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Pozycje pliku z operacjami GSM
    /// </summary>
    public partial class BilingiPlikPoz
    {
        public int IdBilingiPlikPoz { get; set; }
        /// <summary>
        /// Relacja do nagłówka pliku - tab: BILINGI_PLIK
        /// </summary>
        public int? BilingiPlikId { get; set; }
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
        /// Relacja do karty SIM - tab: SIM
        /// </summary>
        public int? SimId { get; set; }
        /// <summary>
        /// Numer karty SIM - numer telefonu
        /// </summary>
        public string Sim { get; set; }
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
        /// Kwota netto transakcji
        /// </summary>
        public double? KwotaNetto { get; set; }
        /// <summary>
        /// Stawka VAT dla transakcji
        /// </summary>
        public double? StawkaVat { get; set; }
        /// <summary>
        /// Kwota VAT transakcji
        /// </summary>
        public double? KwotaVat { get; set; }
        /// <summary>
        /// Kwota brutto transakcji
        /// </summary>
        public double? KwotaBrutto { get; set; }
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
        /// Numer boczny pojazdu
        /// </summary>
        public string TaborNrB { get; set; }
        /// <summary>
        /// Relacja do zlecenia - tab: ZLECENIA
        /// </summary>
        public int? ZleceniaId { get; set; }
        /// <summary>
        /// Numer zlecenia
        /// </summary>
        public string Zlecenia { get; set; }
        /// <summary>
        /// Relacja do trasy - tab: LISTY_LINIOWE
        /// </summary>
        public int? ListyLinioweId { get; set; }
        /// <summary>
        /// Numer trasy
        /// </summary>
        public string ListyLiniowe { get; set; }
        /// <summary>
        /// Numer telefonu na jaki dzwoniopno
        /// </summary>
        public string PolaczenieWych { get; set; }
        /// <summary>
        /// Relacja do pracownika - tab: KIEROWCY
        /// </summary>
        public int? PracownikId { get; set; }
        /// <summary>
        /// Nazwisko i imię pracownika
        /// </summary>
        public string Pracownik { get; set; }
        /// <summary>
        /// 0 - połączenia, 1 - abonament, 2 - inne
        /// </summary>
        public int? TypDanych { get; set; }
    }
}
