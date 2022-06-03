using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Dane oddziałów kontrahenta
    /// </summary>
    public partial class KontrahenciOddzialy
    {
        public int IdKontrahenciOddzialy { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int KontrahId { get; set; }
        /// <summary>
        /// Nazwa oddziału
        /// </summary>
        public string Nazwa { get; set; }
        /// <summary>
        /// Adres
        /// </summary>
        public string Adres { get; set; }
        /// <summary>
        /// Numer telefonu
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// Numer faksu
        /// </summary>
        public string Fax { get; set; }
        /// <summary>
        /// Adres e-mail
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Osoba kontaktowa
        /// </summary>
        public string Osoba { get; set; }
        /// <summary>
        /// GPS - długość
        /// </summary>
        public double? GeoLongi { get; set; }
        /// <summary>
        /// GPS - szerokość
        /// </summary>
        public double? GeoLat { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Dział
        /// </summary>
        public string Dzial { get; set; }
        /// <summary>
        /// Kod pocztowy
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// Miejscowość
        /// </summary>
        public string Miasto { get; set; }
        /// <summary>
        /// Kraj
        /// </summary>
        public string Kraj { get; set; }
        /// <summary>
        /// Flaga, czy wysyłać wiadomości mailingowe
        /// </summary>
        public int? Mailing { get; set; }
        /// <summary>
        /// Konto księgowe 1
        /// </summary>
        public string KontoFk { get; set; }
        /// <summary>
        /// Relacja do POI - tab: MIEJSCA_ZA_ROZLADUNKU
        /// </summary>
        public int? MiejscaZaRozladunkuId { get; set; }
        public string OpisDod { get; set; }
        /// <summary>
        /// Relacja do kontrahenta powiązanego - tab: KONTRAHENCI
        /// </summary>
        public int? KontrahenciId { get; set; }
        /// <summary>
        /// Typ powiązania
        /// </summary>
        public string TypPowiazania { get; set; }
        /// <summary>
        /// Nazwa oddziału
        /// </summary>
        public string Symbol { get; set; }
        /// <summary>
        /// Flaga, czy wysyłać eFaktury
        /// </summary>
        public int? EFaktury { get; set; }
        /// <summary>
        /// Adres mailowy do eFaktur
        /// </summary>
        public string EFakturyEmail { get; set; }
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
        /// Adr. koresp. - Nazwa
        /// </summary>
        public string NazwaK { get; set; }
        /// <summary>
        /// Adr. koresp. - Adres (ulica i numery)
        /// </summary>
        public string AdresK { get; set; }
        /// <summary>
        /// Adr. koresp. - Miejscowość
        /// </summary>
        public string MiastoK { get; set; }
        /// <summary>
        /// Adr. koresp. - Kod pocztowy
        /// </summary>
        public string KodK { get; set; }
        /// <summary>
        /// Adr. koresp. - Kraj
        /// </summary>
        public string KrajK { get; set; }
        /// <summary>
        /// Flaga, czy są duplikaty po SYMBOL-u
        /// </summary>
        public int? DuplikatySym { get; set; }
        /// <summary>
        /// Flaga, czy nadrżedny dla duplikatów
        /// </summary>
        public int? DuplikatyNadrz { get; set; }
    }
}
