using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Przydział kart na okaziciela
    /// </summary>
    public partial class KartyPrzydzial
    {
        public int IdKartyPrzydzial { get; set; }
        /// <summary>
        /// Relacja do karty - tab: KARTY
        /// </summary>
        public int? KartyId { get; set; }
        /// <summary>
        /// Data/Godz od
        /// </summary>
        public DateTime? DataGodzOd { get; set; }
        /// <summary>
        /// Data/Godz do
        /// </summary>
        public DateTime? DataGodzDo { get; set; }
        /// <summary>
        /// Relacja do kierowcy - tab: KIEROWCY
        /// </summary>
        public int? KierowcaId { get; set; }
        /// <summary>
        /// Nazwisko i imię kierowcy
        /// </summary>
        public string Kierowca { get; set; }
        /// <summary>
        /// Relacja do pojazdu - tab: TABOR
        /// </summary>
        public int? TaborId { get; set; }
        /// <summary>
        /// Nr rejestracyjny pojazdu
        /// </summary>
        public string Tabor { get; set; }
        /// <summary>
        /// Dowolne uwagi do przycdziału karty
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
