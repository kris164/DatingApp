using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WMagInwent
    {
        public int IdWMagInwent { get; set; }
        public string Magazyn { get; set; }
        public DateTime? Data { get; set; }
        public string Status { get; set; }
        public string WMagWydania { get; set; }
        public int? WMagWydaniaId { get; set; }
        public string WMagPrzyjecia { get; set; }
        public int? WMagPrzyjeciaId { get; set; }
        public string Uwagi { get; set; }
        public string UwagiDoRozl { get; set; }
        public int? Zalaczniki { get; set; }
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
        public DateTime? InwNaDzien { get; set; }
    }
}
