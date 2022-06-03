using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Giełda pojazdów
    /// </summary>
    public partial class GieldaPojazdow
    {
        public int IdGieldaPojazdow { get; set; }
        /// <summary>
        /// Flaga, czy wpis anulowany
        /// </summary>
        public int? Anulowany { get; set; }
        /// <summary>
        /// Data/Godz wprowadzenia
        /// </summary>
        public DateTime? DataGodz { get; set; }
        /// <summary>
        /// Data/Godz od
        /// </summary>
        public DateTime? DataGodzOd { get; set; }
        /// <summary>
        /// Data/Godz do
        /// </summary>
        public DateTime? DataGodzDo { get; set; }
        /// <summary>
        /// Relacja do KONTRAHENCI
        /// </summary>
        public int? PrzewoznikId { get; set; }
        /// <summary>
        /// Przewoźnik
        /// </summary>
        public string Przewoznik { get; set; }
        /// <summary>
        /// Relacja do TABOR
        /// </summary>
        public int? TaborId { get; set; }
        /// <summary>
        /// Nr rej
        /// </summary>
        public string Tabor { get; set; }
        /// <summary>
        /// Nr boczny
        /// </summary>
        public string TaborNrB { get; set; }
        /// <summary>
        /// Relacja do tabeli KIEROWCY
        /// </summary>
        public int? Kierowca1Id { get; set; }
        /// <summary>
        /// Nazwisko imie kierowcy 1
        /// </summary>
        public string Kierowca1 { get; set; }
        /// <summary>
        /// Telefon do kierowcy 1
        /// </summary>
        public string Kierowca1Tel { get; set; }
        /// <summary>
        /// Relacja do tabeli KIEROWCY
        /// </summary>
        public int? Kierowca2Id { get; set; }
        /// <summary>
        /// Nazwisko imie kierowcy 2
        /// </summary>
        public string Kierowca2 { get; set; }
        /// <summary>
        /// Telefon do kierowcy 2
        /// </summary>
        public string Kierowca2Tel { get; set; }
        /// <summary>
        /// Typ źródła danych
        /// </summary>
        public int? ObiektTyp { get; set; }
        /// <summary>
        /// Relacja do obiektu: ZLECENIA, LISTY_LINIOWE
        /// </summary>
        public int? ObiektId { get; set; }
        /// <summary>
        /// Numer obiektu
        /// </summary>
        public string Obiekt { get; set; }
        /// <summary>
        /// Lokalizacja wprowadzająca na giełdę
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Dział wprowadzajacy na giełdę
        /// </summary>
        public string Dzial { get; set; }
        /// <summary>
        /// Relacja do UZYTKOWNICY
        /// </summary>
        public int? PracownikId { get; set; }
        /// <summary>
        /// Użytkownik wprowadzajacy na giełdę
        /// </summary>
        public string Pracownik { get; set; }
        /// <summary>
        /// Flaga, czy odesłać do lokalizacji wprowadz.
        /// </summary>
        public int? Odeslac { get; set; }
        /// <summary>
        /// ID POI-a
        /// </summary>
        public int? OstPoiId { get; set; }
        /// <summary>
        /// Nazwa POI-a
        /// </summary>
        public string OstPoiNazwa { get; set; }
        /// <summary>
        /// Adres POI-a
        /// </summary>
        public string OstPoiAdres { get; set; }
        /// <summary>
        /// Miejscowość POI-a
        /// </summary>
        public string OstPoiMiasto { get; set; }
        /// <summary>
        /// Kod pocztowy POI-a
        /// </summary>
        public string OstPoiKod { get; set; }
        /// <summary>
        /// Kraj POI-a
        /// </summary>
        public string OstPoiKraj { get; set; }
        /// <summary>
        /// Telefon do POI-a
        /// </summary>
        public string OstPoiTel { get; set; }
        /// <summary>
        /// Fax do POI-a
        /// </summary>
        public string OstPoiFax { get; set; }
        /// <summary>
        /// GPS - długość
        /// </summary>
        public double? OstPoiGeoLongi { get; set; }
        /// <summary>
        /// GPS - szerokość
        /// </summary>
        public double? OstPoiGeoLat { get; set; }
        /// <summary>
        /// Strefa
        /// </summary>
        public string Strefa { get; set; }
        /// <summary>
        /// Uwagi
        /// </summary>
        public string Uwagi { get; set; }
        /// <summary>
        /// Flaga, czy rezerwacja wstępna
        /// </summary>
        public int? Rez { get; set; }
        /// <summary>
        /// Data/Godz rezerwacji
        /// </summary>
        public DateTime? RezDataGodz { get; set; }
        /// <summary>
        /// Lokalizacja rezerwująca
        /// </summary>
        public string RezLokalizacja { get; set; }
        /// <summary>
        /// Relacja do UZYTKOWNICY
        /// </summary>
        public int? RezPracownikId { get; set; }
        /// <summary>
        /// Użytkownik rezerwujący
        /// </summary>
        public string RezPracownik { get; set; }
        /// <summary>
        /// Uwagi do rezerwacji
        /// </summary>
        public string RezUwagi { get; set; }
        /// <summary>
        /// Flaga, czy pobrano
        /// </summary>
        public int? Pobr { get; set; }
        /// <summary>
        /// Data/Godz pobrania
        /// </summary>
        public DateTime? PobrDataGodz { get; set; }
        /// <summary>
        /// Lokalizacja pobierająca
        /// </summary>
        public string PobrLokalizacja { get; set; }
        /// <summary>
        /// Relacja do UZYTKOWNICY
        /// </summary>
        public int? PobrPracownikId { get; set; }
        /// <summary>
        /// Użytkownik pobierajacy
        /// </summary>
        public string PobrPracownik { get; set; }
        /// <summary>
        /// Uwagi do pobrania
        /// </summary>
        public string PobrUwagi { get; set; }
        /// <summary>
        /// Typ źródła danych na który pobrano
        /// </summary>
        public int? PobrObiektTyp { get; set; }
        /// <summary>
        /// Relacja do obiektu na który pobrano: ZLECENIA, LISTY_LINIOWE
        /// </summary>
        public int? PobrObiektId { get; set; }
        /// <summary>
        /// Numer obiektu na który pobrano
        /// </summary>
        public string PobrObiekt { get; set; }
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
        /// Rodzaj: P - pojazd / Z - zlecenie
        /// </summary>
        public string Rodzaj { get; set; }
        /// <summary>
        /// Relacja do TABOR
        /// </summary>
        public int? NaczepaId { get; set; }
        /// <summary>
        /// Nr rej
        /// </summary>
        public string Naczepa { get; set; }
        /// <summary>
        /// Nr boczny
        /// </summary>
        public string NaczepaNrB { get; set; }
        /// <summary>
        /// Typ POI-a
        /// </summary>
        public string OstPoiTyp { get; set; }
        public int? Dorazny { get; set; }
        public string UwagiDoPojazdu { get; set; }
        public string WarunkiDodatkowe { get; set; }
        public string Status { get; set; }
        /// <summary>
        /// null/0 - recznie, 1 - automat
        /// </summary>
        public int? Zrodlo { get; set; }
        /// <summary>
        /// Czy zlecenie ADR / Kierowca ma upr. ADR
        /// </summary>
        public int? Adr { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string OstPoiLokalizacja { get; set; }
        /// <summary>
        /// Data/Godz ZA
        /// </summary>
        public DateTime? DataZa { get; set; }
        /// <summary>
        /// Data/Godz WY
        /// </summary>
        public DateTime? DataWy { get; set; }
        /// <summary>
        /// Typ POI-a
        /// </summary>
        public string PoczPoiTyp { get; set; }
        /// <summary>
        /// ID POI-a
        /// </summary>
        public int? PoczPoiId { get; set; }
        /// <summary>
        /// Nazwa POI-a
        /// </summary>
        public string PoczPoiNazwa { get; set; }
        /// <summary>
        /// Adres POI-a
        /// </summary>
        public string PoczPoiAdres { get; set; }
        /// <summary>
        /// Miejscowość POI-a
        /// </summary>
        public string PoczPoiMiasto { get; set; }
        /// <summary>
        /// Kod pocztowy POI-a
        /// </summary>
        public string PoczPoiKod { get; set; }
        /// <summary>
        /// Kraj POI-a
        /// </summary>
        public string PoczPoiKraj { get; set; }
        /// <summary>
        /// Telefon do POI-a
        /// </summary>
        public string PoczPoiTel { get; set; }
        /// <summary>
        /// Fax do POI-a
        /// </summary>
        public string PoczPoiFax { get; set; }
        /// <summary>
        /// GPS - długość
        /// </summary>
        public double? PoczPoiGeoLongi { get; set; }
        /// <summary>
        /// GPS - szerokość
        /// </summary>
        public double? PoczPoiGeoLat { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string PoczPoiLokalizacja { get; set; }
        /// <summary>
        /// Strefa
        /// </summary>
        public string PoczStrefa { get; set; }
    }
}
