using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Rozliczenia palet w lokalizacjach
    /// </summary>
    public partial class KwitPalRozlLok
    {
        public int IdKwitPalRozlLok { get; set; }
        /// <summary>
        /// Typ rozliczenia 0 - normalne, 1 - kompensata
        /// </summary>
        public int? Typ { get; set; }
        /// <summary>
        /// Data ROZL
        /// </summary>
        public DateTime? Data { get; set; }
        /// <summary>
        /// Numer ROZL
        /// </summary>
        public string NrRozlLok { get; set; }
        /// <summary>
        /// Numer kolejny z licznika
        /// </summary>
        public int? NrRozlLokKolejny { get; set; }
        /// <summary>
        /// Rok z licznika
        /// </summary>
        public int? NrRozlLokRok { get; set; }
        /// <summary>
        /// Miesiac z licznika
        /// </summary>
        public int? NrRozlLokMies { get; set; }
        /// <summary>
        /// Lokalizacja która palety ma
        /// </summary>
        public string LokalizacjaZ { get; set; }
        /// <summary>
        /// Lokalizacja która palety ma mieć
        /// </summary>
        public string LokalizacjaDo { get; set; }
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
        /// Okres od
        /// </summary>
        public DateTime? DataOd { get; set; }
        /// <summary>
        /// Okres do
        /// </summary>
        public DateTime? DataDo { get; set; }
        /// <summary>
        /// Procedura bazodanowa
        /// </summary>
        public string ProceduraDb { get; set; }
    }
}
