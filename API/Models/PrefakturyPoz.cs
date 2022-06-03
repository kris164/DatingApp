using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Pozycje prefaktury/bilingu
    /// </summary>
    public partial class PrefakturyPoz
    {
        public int IdPrefakturyPoz { get; set; }
        /// <summary>
        /// Relacja do PREFAKTURY, tab: PREFAKTURY
        /// </summary>
        public int PrefakturyId { get; set; }
        /// <summary>
        /// Flaga/status gotowości do FV
        /// </summary>
        public int? Stan { get; set; }
        /// <summary>
        /// LP - wg tego LP dane trafią na FV
        /// </summary>
        public int? Lp { get; set; }
        /// <summary>
        /// Relacja do pozycji FV, tab: POZYCJE_FAKTUR
        /// </summary>
        public int? TytulId { get; set; }
        /// <summary>
        /// Kod pozycji FV
        /// </summary>
        public string TytulKod { get; set; }
        /// <summary>
        /// Tytuł pozycji FV
        /// </summary>
        public string Tytul { get; set; }
        /// <summary>
        /// Dodatkowy opic pozycji FV
        /// </summary>
        public string TytulOpis { get; set; }
        /// <summary>
        /// jm
        /// </summary>
        public string Jm { get; set; }
        /// <summary>
        /// Ilość
        /// </summary>
        public double Ilosc { get; set; }
        /// <summary>
        /// Cena jednostkowa
        /// </summary>
        public double NettoJedn { get; set; }
        /// <summary>
        /// Cena razem
        /// </summary>
        public double Netto { get; set; }
        /// <summary>
        /// Wartość rabatu w %
        /// </summary>
        public double Rabat { get; set; }
        /// <summary>
        /// Kod stawki VAT
        /// </summary>
        public string VatId { get; set; }
        /// <summary>
        /// Stawka VAT
        /// </summary>
        public double VatStawka { get; set; }
        /// <summary>
        /// Waluta pozycji
        /// </summary>
        public string Waluta { get; set; }
        /// <summary>
        /// Waluta na FV
        /// </summary>
        public string WalutaFv { get; set; }
        /// <summary>
        /// Relacja do kalkulacji, tab: KALKULACJE
        /// </summary>
        public int? KalkulacjeId { get; set; }
        /// <summary>
        /// Relacja do przesyłki, tab: PRZESYLKI
        /// </summary>
        public int? PrzesylkaId { get; set; }
        /// <summary>
        /// Nr przesyłki
        /// </summary>
        public string Przesylka { get; set; }
        /// <summary>
        /// Relacja do poz. dod. zlecenia FTL, tab: ZLECENIA_POZ_FAKT
        /// </summary>
        public int? ZlecPozFaktId { get; set; }
        /// <summary>
        /// Odcinek zlecenia FTL (KR, UE, ZG)
        /// </summary>
        public string Odcinek { get; set; }
        /// <summary>
        /// Relacja do zlecenia FTL, tab: ZLECENIA
        /// </summary>
        public int? ZlecenieId { get; set; }
        /// <summary>
        /// Nr zlecenia FTL
        /// </summary>
        public string Zlecenie { get; set; }
        /// <summary>
        /// Relacja do zlecenia morskiego, tab: ZLECENIA_M
        /// </summary>
        public int? ZlecenieMId { get; set; }
        /// <summary>
        /// Nr zlecenia morskiego
        /// </summary>
        public string ZlecenieM { get; set; }
        /// <summary>
        /// Relacja do trasy, tab: LISTY_LINIOWE
        /// </summary>
        public int? ListLiniowyId { get; set; }
        /// <summary>
        /// Nr trasy drobnicowej
        /// </summary>
        public string ListLiniowy { get; set; }
        /// <summary>
        /// Relacja do pojazdu, tab: TABOR
        /// </summary>
        public int? TaborId { get; set; }
        /// <summary>
        /// Nr rej pojazdu
        /// </summary>
        public string Tabor { get; set; }
        /// <summary>
        /// Relacja do naczepy, tab: TABOR
        /// </summary>
        public int? NaczepaId { get; set; }
        /// <summary>
        /// Nr rej naczepy
        /// </summary>
        public string Naczepa { get; set; }
        /// <summary>
        /// Relacja do kierowcy, tab: KIEROWCY
        /// </summary>
        public int? KierowcaId { get; set; }
        /// <summary>
        /// Nazwisko i imię kierowcy
        /// </summary>
        public string Kierowca { get; set; }
        /// <summary>
        /// Relacja do promu, tab: PROMY
        /// </summary>
        public int? PromyId { get; set; }
        /// <summary>
        /// Numer promu
        /// </summary>
        public string Promy { get; set; }
        /// <summary>
        /// Dotyczy lokalizacji
        /// </summary>
        public string DotLokalizacji { get; set; }
        /// <summary>
        /// Dotyczy działu
        /// </summary>
        public string DotDzialu { get; set; }
        /// <summary>
        /// Powód zmiany kwoty
        /// </summary>
        public string PowZmKwoty { get; set; }
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
        /// <summary>
        /// Relacja do zlecenia morskiego, tab: ZLECENIA_M
        /// </summary>
        public int? ZlecenieRailId { get; set; }
        /// <summary>
        /// Nr zlecenia morskiego
        /// </summary>
        public string ZlecenieRail { get; set; }
    }
}
