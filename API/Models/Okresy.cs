using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Okresy rozliczeniowe dla dokumentów księgowych
    /// </summary>
    public partial class Okresy
    {
        public int IdOkresy { get; set; }
        /// <summary>
        /// Typ okresu: 0-tygodniowy, 1-miesieczny, 2-roczny
        /// </summary>
        public int? Okres { get; set; }
        /// <summary>
        /// Data od
        /// </summary>
        public DateTime? DataOd { get; set; }
        /// <summary>
        /// Data do
        /// </summary>
        public DateTime? DataDo { get; set; }
        /// <summary>
        /// Numer tygodnia
        /// </summary>
        public int? Tydzien { get; set; }
        /// <summary>
        /// Miesiąc
        /// </summary>
        public int? Miesiac { get; set; }
        /// <summary>
        /// Rok
        /// </summary>
        public int? Rok { get; set; }
        /// <summary>
        /// Stan okresu: O, Z
        /// </summary>
        public string Stan { get; set; }
        /// <summary>
        /// Dodatkowe informacje użytkownika
        /// </summary>
        public string Info { get; set; }
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
