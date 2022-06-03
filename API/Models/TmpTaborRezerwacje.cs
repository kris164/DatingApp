using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpTaborRezerwacje
    {
        public int IdTmpTaborRezerwacje { get; set; }
        public int? IdSesjiKalk { get; set; }
        public int? IdTaborRezerwacje { get; set; }
        /// <summary>
        /// Relacja do pojazdu - tab: TABOR
        /// </summary>
        public int? TaborId { get; set; }
        /// <summary>
        /// Numer rejestracyjny pojazdu
        /// </summary>
        public string Tabor { get; set; }
        /// <summary>
        /// Numer boczny pojazdu
        /// </summary>
        public string TaborNrB { get; set; }
        /// <summary>
        /// Relacja do naczepy - tab: TABOR
        /// </summary>
        public int? NaczepaId { get; set; }
        /// <summary>
        /// Relacja do kierowcy 1 - tab: KIEROWCY
        /// </summary>
        public int? KierowcaId { get; set; }
        /// <summary>
        /// Relacja do kierowcy 2 - tab: KIEROWCY
        /// </summary>
        public int? Kierowca2Id { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int? KlientId { get; set; }
        /// <summary>
        /// Symbol kontrahenta
        /// </summary>
        public string Klient { get; set; }
        /// <summary>
        /// Miasto kontrahenta
        /// </summary>
        public string KlientMiasto { get; set; }
        /// <summary>
        /// Relacja do oddziału kontrahenta - tab: KONTRAHENCI_ODDZIALY
        /// </summary>
        public int? KlientOddzialId { get; set; }
        /// <summary>
        /// Oddział kontrahenta
        /// </summary>
        public string KlientOddzial { get; set; }
        /// <summary>
        /// Typ rezerwacji
        /// </summary>
        public string Typ { get; set; }
        /// <summary>
        /// Rodzaj rezerwacji
        /// </summary>
        public string Rodzaj { get; set; }
        /// <summary>
        /// Data rejestracji rezerwacji
        /// </summary>
        public DateTime? DataRej { get; set; }
        /// <summary>
        /// Rezerwacja od dnia
        /// </summary>
        public DateTime? DataOd { get; set; }
        /// <summary>
        /// Rezerwacja od godziny
        /// </summary>
        public DateTime? GodzOd { get; set; }
        /// <summary>
        /// Rezerwacja do dnia
        /// </summary>
        public DateTime? DataDo { get; set; }
        /// <summary>
        /// Rezerwacja do godziny
        /// </summary>
        public DateTime? GodzDo { get; set; }
        /// <summary>
        /// Rezerwacja od dnia
        /// </summary>
        public DateTime? DataOdRz { get; set; }
        /// <summary>
        /// Rezerwacja od godziny
        /// </summary>
        public DateTime? GodzOdRz { get; set; }
        /// <summary>
        /// Rezerwacja do dnia
        /// </summary>
        public DateTime? DataDoRz { get; set; }
        /// <summary>
        /// Rezerwacja do godziny
        /// </summary>
        public DateTime? GodzDoRz { get; set; }
        /// <summary>
        /// Skala ważności
        /// </summary>
        public int? Waznosc { get; set; }
        /// <summary>
        /// Status rezerwacji (N-Nowe P-Zaplanowane R-Realizowane Z-Zakończone)
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// Relacja do zlecenia warsztatowego - tab: W_ZLECENIA
        /// </summary>
        public int? WZlecenieId { get; set; }
        /// <summary>
        /// Numer zlecenia warsztatowego
        /// </summary>
        public string WZlecenie { get; set; }
        /// <summary>
        /// Dowolne uwagi do rezerwacji
        /// </summary>
        public string Uwagi { get; set; }
        /// <summary>
        /// Ilość załączników
        /// </summary>
        public int? Zalaczniki { get; set; }
        public int? Poi { get; set; }
        public int? PoiId { get; set; }
        /// <summary>
        /// Nazwa POI-a
        /// </summary>
        public string PoiNazwa { get; set; }
        /// <summary>
        /// Adres POI-a
        /// </summary>
        public string PoiAdres { get; set; }
        /// <summary>
        /// Miejscowość POI-a
        /// </summary>
        public string PoiMiasto { get; set; }
        /// <summary>
        /// Kod pocztowy POI-a
        /// </summary>
        public string PoiKod { get; set; }
        /// <summary>
        /// Kraj POI-a
        /// </summary>
        public string PoiKraj { get; set; }
        /// <summary>
        /// GPS - długość
        /// </summary>
        public double? PoiLon { get; set; }
        /// <summary>
        /// GPS - szerokość
        /// </summary>
        public double? PoiLat { get; set; }
        /// <summary>
        /// Relacja do oferty warsztatowej - tab: W_ZLECENIA_OFERTY
        /// </summary>
        public int? WZleceniaOfertyId { get; set; }
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
        public int? ZLadunkiem { get; set; }
    }
}
