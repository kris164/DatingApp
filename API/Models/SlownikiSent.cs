using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SlownikiSent
    {
        public int IdSlownikiSent { get; set; }
        /// <summary>
        /// Kod słownika
        /// </summary>
        public int? Code { get; set; }
        /// <summary>
        /// Wersja słownika
        /// </summary>
        public int? Version { get; set; }
        /// <summary>
        /// Nazwa słownika
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Nazwa pliku
        /// </summary>
        public string FileName { get; set; }
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
