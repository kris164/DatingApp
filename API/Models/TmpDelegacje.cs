using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpDelegacje
    {
        public int IdTmpDelegacje { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        /// <summary>
        /// Data delegacji
        /// </summary>
        public DateTime? Data { get; set; }
        /// <summary>
        /// Relacja do PW, tab: WYJAZDY
        /// </summary>
        public int? WyjazdId { get; set; }
        /// <summary>
        /// Licz OD zdarzenia PW, tab: WYJAZDY_ZDARZENIA
        /// </summary>
        public int? WyjazdyZdarzeniaOdId { get; set; }
        /// <summary>
        /// Licz DO zdarzenia PW, tab: WYJAZDY_ZDARZENIA
        /// </summary>
        public int? WyjazdyZdarzeniaDoId { get; set; }
        /// <summary>
        /// Relacja do pracownika, tab: KIEROWCY
        /// </summary>
        public int? PracownikId { get; set; }
        /// <summary>
        /// Flaga, czy rozliczono delegacje
        /// </summary>
        public int? Rozliczono { get; set; }
        /// <summary>
        /// Data rozliczenia
        /// </summary>
        public DateTime? DataRozliczenia { get; set; }
        /// <summary>
        /// Kraj docelowy
        /// </summary>
        public string KrajDocelowy { get; set; }
        /// <summary>
        /// Relacja do tabeli kursowej dla rozliczenia
        /// </summary>
        public int? KursyWalutId { get; set; }
        /// <summary>
        /// Kurs waluty dla rozliczenia
        /// </summary>
        public double? Kurs { get; set; }
        /// <summary>
        /// Data kursu waluty dla rozliczenia
        /// </summary>
        public DateTime? KursyWalutData { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Dział
        /// </summary>
        public string Dzial { get; set; }
        /// <summary>
        /// Flaga, czy liczyć noclegi automatem
        /// </summary>
        public int? LiczNoclegi { get; set; }
        public int? IdDelegacje { get; set; }
        /// <summary>
        /// Licznik - numer
        /// </summary>
        public string NrDelegacji { get; set; }
        /// <summary>
        /// Licznik - nr kolejny
        /// </summary>
        public int? NrDelegacjiKolejny { get; set; }
        /// <summary>
        /// Licznik - rok
        /// </summary>
        public int? NrDelegacjiRok { get; set; }
        /// <summary>
        /// Licznik - miesiąc
        /// </summary>
        public int? NrDelegacjiMies { get; set; }
        /// <summary>
        /// Numer PW
        /// </summary>
        public string Wyjazd { get; set; }
        /// <summary>
        /// Imię i nazwisko pracownika
        /// </summary>
        public string Pracownik { get; set; }
        /// <summary>
        /// Cel wyjazdu
        /// </summary>
        public string CelWyjazdu { get; set; }
        /// <summary>
        /// Stanowisko pracownika
        /// </summary>
        public string Stanowisko { get; set; }
        /// <summary>
        /// Srodek lokomocji
        /// </summary>
        public string SrodkiLokomocji { get; set; }
        /// <summary>
        /// Miejsce docelowe
        /// </summary>
        public string MiejsceDocelowe { get; set; }
        /// <summary>
        /// Wyjazd w okresie OD
        /// </summary>
        public DateTime? WyjazdOd { get; set; }
        /// <summary>
        /// Wyjazd w okresie DO
        /// </summary>
        public DateTime? WyjazdDo { get; set; }
        /// <summary>
        /// Data wyjazdu
        /// </summary>
        public DateTime? DataWyjazdu { get; set; }
        /// <summary>
        /// Data powrotu
        /// </summary>
        public DateTime? DataPowrotu { get; set; }
        /// <summary>
        /// Godzina wyjazdu
        /// </summary>
        public DateTime? GodzWyjazdu { get; set; }
        /// <summary>
        /// Godzina powrotu
        /// </summary>
        public DateTime? GodzPowrotu { get; set; }
        /// <summary>
        /// Flaga, czy delegacja zagraniczna
        /// </summary>
        public int? Zagraniczna { get; set; }
        /// <summary>
        /// Data wyjazdu z kraju
        /// </summary>
        public DateTime? DataWyjazduGranica { get; set; }
        /// <summary>
        /// Data powrotu do kraju
        /// </summary>
        public DateTime? DataPowrotuGranica { get; set; }
        /// <summary>
        /// Godzina wyjazdu z kraju
        /// </summary>
        public DateTime? GodzWyjazduGranica { get; set; }
        /// <summary>
        /// Godzina powrotu do kraju
        /// </summary>
        public DateTime? GodzPowrotuGranica { get; set; }
        /// <summary>
        /// Ilość dob delegacji krajowej
        /// </summary>
        public int? DobyKraj { get; set; }
        /// <summary>
        /// Ilość godzin delegacji krajowej
        /// </summary>
        public double? GodzinyKraj { get; set; }
        /// <summary>
        /// Ilość dob delegacji zagranicznej
        /// </summary>
        public int? DobyZagr { get; set; }
        /// <summary>
        /// Ilość godzin delegacji zagranicznej
        /// </summary>
        public double? GodzinyZagr { get; set; }
        /// <summary>
        /// Ilość noclegów krajowych
        /// </summary>
        public int? NoclegiKraj { get; set; }
        /// <summary>
        /// Ilość noclegów zagranicznych
        /// </summary>
        public int? NoclegiZagr { get; set; }
        /// <summary>
        /// Nr tabeli kursowej dla rozliczenia
        /// </summary>
        public string KursyWalut { get; set; }
        /// <summary>
        /// Waluta diety krajowej
        /// </summary>
        public string DietaKrajWaluta { get; set; }
        /// <summary>
        /// Waluta diety zagranicznej
        /// </summary>
        public string DietaZagrWaluta { get; set; }
        /// <summary>
        /// Dieta krajowa
        /// </summary>
        public double? DietaKraj { get; set; }
        /// <summary>
        /// Dieta zagraniczna
        /// </summary>
        public double? DietaZagr { get; set; }
        /// <summary>
        /// Noclegi krajowe
        /// </summary>
        public double? NoclegKraj { get; set; }
        /// <summary>
        /// Noclegi zagraniczne
        /// </summary>
        public double? NoclegZagr { get; set; }
        /// <summary>
        /// Inne koszty krajowe
        /// </summary>
        public double? InneKraj { get; set; }
        /// <summary>
        /// Inne koszty zagraniczne
        /// </summary>
        public double? InneZagr { get; set; }
        /// <summary>
        /// Diety razem - krajowe
        /// </summary>
        public double? DietyRazemKraj { get; set; }
        /// <summary>
        /// Diety razem - zagraniczne
        /// </summary>
        public double? DietyRazemZagr { get; set; }
        /// <summary>
        /// Uwagi
        /// </summary>
        public string Uwagi { get; set; }
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
    }
}
