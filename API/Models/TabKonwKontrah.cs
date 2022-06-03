using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Tabele konwersji danych kontrahentów - na potrzeby interfejsów
    /// </summary>
    public partial class TabKonwKontrah
    {
        public int IdTabKonwKontrah { get; set; }
        /// <summary>
        /// Relacja do systemów wymiany danych - tab: SYST_WYM_DANYCH
        /// </summary>
        public int? SystWymDanychId { get; set; }
        /// <summary>
        /// Nazwa interfejsu
        /// </summary>
        public string IntfName { get; set; }
        /// <summary>
        /// Nazwa słownika
        /// </summary>
        public string Slownik { get; set; }
        /// <summary>
        /// Identyfikator w SPEED
        /// </summary>
        public int? SpeedId { get; set; }
        /// <summary>
        /// Symbol w SPEED
        /// </summary>
        public string SpeedSymbol { get; set; }
        /// <summary>
        /// Dane zewn. - ID
        /// </summary>
        public string ExtId { get; set; }
        /// <summary>
        /// Dane zewn. - Symbol
        /// </summary>
        public string ExtSymbol { get; set; }
        /// <summary>
        /// Dane zewn. - Nazwa
        /// </summary>
        public string ExtNazwa { get; set; }
        /// <summary>
        /// Dane zewn. - Adres
        /// </summary>
        public string ExtAdres { get; set; }
        /// <summary>
        /// Dane zewn. - Kod pocztowy
        /// </summary>
        public string ExtKodP { get; set; }
        /// <summary>
        /// Dane zewn. - Miasto
        /// </summary>
        public string ExtMiasto { get; set; }
        /// <summary>
        /// Dane zewn. - Kraj
        /// </summary>
        public string ExtKraj { get; set; }
        /// <summary>
        /// Dane zewn. - NIP
        /// </summary>
        public string ExtNip { get; set; }
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
