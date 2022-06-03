using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik miejsc za/rozładunky (POI-e)
    /// </summary>
    public partial class MiejscaZaRozladunku
    {
        public int IdMiejscaZaRozladunku { get; set; }
        /// <summary>
        /// Rodzaj systemowy (MC_ZA_WY, MC_GRANICA, etc)
        /// </summary>
        public string RodzajM { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab.: KONTRAHENCI
        /// </summary>
        public int? KlientId { get; set; }
        /// <summary>
        /// Symbol kontrahenta
        /// </summary>
        public string Klient { get; set; }
        /// <summary>
        /// Nazwa POI-a
        /// </summary>
        public string Nazwa { get; set; }
        /// <summary>
        /// Adres POI-a
        /// </summary>
        public string Adres { get; set; }
        /// <summary>
        /// Miejscowość POI-a
        /// </summary>
        public string Miasto { get; set; }
        /// <summary>
        /// Kod pocztowy POI-a
        /// </summary>
        public string KodPoczt { get; set; }
        /// <summary>
        /// Kraj POI-a
        /// </summary>
        public string Kraj { get; set; }
        /// <summary>
        /// Telefon do POI-a
        /// </summary>
        public string Telefony { get; set; }
        /// <summary>
        /// Flaga, czy POI jest określony adresem czy opisowo
        /// </summary>
        public int? Opisowo { get; set; }
        /// <summary>
        /// Opis POI-a
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// GPS - długość
        /// </summary>
        public double? GeoLongi { get; set; }
        /// <summary>
        /// GPS - szerokość
        /// </summary>
        public double? GeoLat { get; set; }
        /// <summary>
        /// Domyśłny czas trwania zdarzenia na POI-u
        /// </summary>
        public double? CzasTrwania { get; set; }
        /// <summary>
        /// Dowolne uwagi do POI-a
        /// </summary>
        public string Uwagi { get; set; }
        /// <summary>
        /// Flaga, czy wysyłać uwagi (SFM)
        /// </summary>
        public int? WysylacUwagi { get; set; }
        /// <summary>
        /// Zewnętrzny ID - na potrzeby interfejsów
        /// </summary>
        public long? Idpoiext { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Flaga, czy POI jest miejscem załadunku
        /// </summary>
        public int? Za { get; set; }
        /// <summary>
        /// Flaga, czy POI jest miejscem wyładunku
        /// </summary>
        public int? Wy { get; set; }
        /// <summary>
        /// Symbol zewnętrzny
        /// </summary>
        public string SymbolEx { get; set; }
        /// <summary>
        /// POI czynny od
        /// </summary>
        public DateTime? GodzOd { get; set; }
        /// <summary>
        /// POI czynny do
        /// </summary>
        public DateTime? GodzDo { get; set; }
        /// <summary>
        /// Flaga, czy POI jest na potrzeby ofertowania
        /// </summary>
        public int? Oferta { get; set; }
        /// <summary>
        /// Symbol POI-a
        /// </summary>
        public string Symbol { get; set; }
        /// <summary>
        /// Województwo POI-a
        /// </summary>
        public string Wojewodztwo { get; set; }
        /// <summary>
        /// Rejon POI-a
        /// </summary>
        public string Rejon { get; set; }
        /// <summary>
        /// Rodzaj użytkownika - dowolny rodzaj wg użytkownika
        /// </summary>
        public string Rodzaj { get; set; }
        /// <summary>
        /// POI wewnętrzny, Relacja do kontrahenta - tab.: KONTRAHENCI
        /// </summary>
        public int? KontrahenciId { get; set; }
        /// <summary>
        /// Kod domyślnej/ standardowej trasy
        /// </summary>
        public string KodStdTrasy { get; set; }
        /// <summary>
        /// Relacja do trasy, tab: TRASY
        /// </summary>
        public int? KodStdTrasyId { get; set; }
        /// <summary>
        /// Adres www do mapy internetowej
        /// </summary>
        public string AdresMapaWww { get; set; }
        /// <summary>
        /// Fax do POI-a
        /// </summary>
        public string Fax { get; set; }
        /// <summary>
        /// Nazwa portu - spedycja morska
        /// </summary>
        public string PortNazwa { get; set; }
        /// <summary>
        /// Symbol portu - spedycja morska
        /// </summary>
        public string PortSymbol { get; set; }
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
        /// GPS - akceptacja
        /// </summary>
        public int? GeoAkceptacja { get; set; }
        /// <summary>
        /// GPS - poziom ufności
        /// </summary>
        public int? GeoPoziomUfn { get; set; }
        /// <summary>
        /// Powiat POI-a
        /// </summary>
        public string Powiat { get; set; }
        /// <summary>
        /// Gmina POI-a
        /// </summary>
        public string Gmina { get; set; }
        /// <summary>
        /// Ilość załączników
        /// </summary>
        public int? Zalaczniki { get; set; }
        /// <summary>
        /// Email do POI-a
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Osoba kontaktowa
        /// </summary>
        public string OsobaKontakt { get; set; }
        public int? DuplikatyNadrz { get; set; }
        public int? MapGeoCoding { get; set; }
        /// <summary>
        /// Język wydruków
        /// </summary>
        public string Lang { get; set; }
        public int? ProvinceId { get; set; }
        public int? SendMail { get; set; }
        public int? SendFax { get; set; }
        /// <summary>
        /// Kod UNLOCO
        /// </summary>
        public string Unloco { get; set; }
        /// <summary>
        /// Opcja wyłaczenia podpisu POD
        /// </summary>
        public int? MSpeedWylaczPodpisPod { get; set; }
        /// <summary>
        /// Opcja wyłaczenia informacji o pobraniu
        /// </summary>
        public int? MSpeedWylaczInfoPobr { get; set; }
        /// <summary>
        /// Kod miejsca dostawy towaru dla przewozu oleju opałowego
        /// </summary>
        public string OilHeatingAddressId { get; set; }
        /// <summary>
        /// Awizacja PRZED
        /// </summary>
        public DateTime? AwizacjaPrzed { get; set; }
        /// <summary>
        /// Opcja wyłaczenia podpisu POP
        /// </summary>
        public int? MSpeedWylaczPodpisPop { get; set; }
        /// <summary>
        /// Opcja wyłaczenia dodawania paczki
        /// </summary>
        public int? MSpeedWylaczDodPaczki { get; set; }
        /// <summary>
        /// Wyłączenie analizy ETA
        /// </summary>
        public int? DisableEta { get; set; }
        /// <summary>
        /// Poi wyłaczony
        /// </summary>
        public int Nieaktywne { get; set; }
    }
}
