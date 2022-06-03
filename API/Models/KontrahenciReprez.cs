using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Dane reprezentantów/pracowników kontrahenta
    /// </summary>
    public partial class KontrahenciReprez
    {
        public int IdKontrahenciReprez { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int KontrahId { get; set; }
        /// <summary>
        /// Nazwisko i imię
        /// </summary>
        public string NazwiskoImie { get; set; }
        /// <summary>
        /// Stanowisko
        /// </summary>
        public string Stanowisko { get; set; }
        /// <summary>
        /// Telefon
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// Telefon komórkowy
        /// </summary>
        public string TelKom { get; set; }
        /// <summary>
        /// E-mail
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Faks
        /// </summary>
        public string Fax { get; set; }
        /// <summary>
        /// Grupa
        /// </summary>
        public string Grupa { get; set; }
        /// <summary>
        /// Numer Gadu-Gadu
        /// </summary>
        public string Gg { get; set; }
        /// <summary>
        /// Numer SKYPE
        /// </summary>
        public string Skype { get; set; }
        /// <summary>
        /// Dowolne uwagi
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Dział
        /// </summary>
        public string Dzial { get; set; }
        /// <summary>
        /// Flaga, czy wysyłać wiadomości mailingowe
        /// </summary>
        public int? Mailing { get; set; }
        /// <summary>
        /// Nazwa oddziału
        /// </summary>
        public string Oddzial { get; set; }
        /// <summary>
        /// Flaga, czy pracownik aktywny
        /// </summary>
        public int? Aktywny { get; set; }
        /// <summary>
        /// Link do giełdy
        /// </summary>
        public string Gielda { get; set; }
        /// <summary>
        /// Flaga, czy eROD
        /// </summary>
        public int? Erod { get; set; }
        /// <summary>
        /// Flaga, czy brać do powiadomienia
        /// </summary>
        public int? Powiadomienie { get; set; }
        /// <summary>
        /// Produkt
        /// </summary>
        public string Produkt { get; set; }
        /// <summary>
        /// Tytuł
        /// </summary>
        public string Tytul { get; set; }
        /// <summary>
        /// Relacja do oddziału
        /// </summary>
        public int? OddzialId { get; set; }
        public string StatusEmisja { get; set; }
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
        /// Liczba załączników
        /// </summary>
        public int? Zalaczniki { get; set; }
    }
}
