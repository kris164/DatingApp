using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Teczki spedycyjne
    /// </summary>
    public partial class Teczki
    {
        public int IdTeczki { get; set; }
        /// <summary>
        /// Numer teczki
        /// </summary>
        public string Numer { get; set; }
        /// <summary>
        /// Numer teczki - nr kolejny
        /// </summary>
        public int? NumerKolejny { get; set; }
        /// <summary>
        /// Numer teczki - rok
        /// </summary>
        public int? NumerRok { get; set; }
        /// <summary>
        /// Numer teczki - miesiąc
        /// </summary>
        public int? NumerMies { get; set; }
        /// <summary>
        /// Rodzaj transportu
        /// </summary>
        public int? RodzajTransportu { get; set; }
        /// <summary>
        /// Opis rodzaju transportu
        /// </summary>
        public string RodzajTransportuOpis { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Opis teczki
        /// </summary>
        public string Opis { get; set; }
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
        /// Ilość załączników
        /// </summary>
        public int? Zalaczniki { get; set; }
        /// <summary>
        /// Relacja do trafiku - tab: TRAFIK
        /// </summary>
        public int? TrafikId { get; set; }
        /// <summary>
        /// Symbol trafiku
        /// </summary>
        public string Trafik { get; set; }
        /// <summary>
        /// Dział
        /// </summary>
        public string Dzial { get; set; }
        /// <summary>
        /// Status teczki: O, Z
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// Data wystawienia
        /// </summary>
        public DateTime? DataWystawienia { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int? KontrahId { get; set; }
        /// <summary>
        /// Symbol kontrahenta
        /// </summary>
        public string Kontrah { get; set; }
        /// <summary>
        /// Relacja do trasy - tab: TRASY
        /// </summary>
        public int? TrasaId { get; set; }
        /// <summary>
        /// Trasa
        /// </summary>
        public string Trasa { get; set; }
        /// <summary>
        /// Data zamknięcia
        /// </summary>
        public DateTime? DataZamkniecia { get; set; }
    }
}
