using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PromyHarmonogram
    {
        public int IdPromyHarmonogram { get; set; }
        public int? ArmatorId { get; set; }
        public string Armator { get; set; }
        public int? LiniaId { get; set; }
        public string Linia { get; set; }
        public int? RelacjaId { get; set; }
        public string RelacjaSymbol { get; set; }
        public string Relacja { get; set; }
        public int? Dzien { get; set; }
        public DateTime? DataWyplyniecia { get; set; }
        public DateTime? GodzWyplyniecia { get; set; }
        public int? CennikId { get; set; }
        public int? PromId { get; set; }
        public string Prom { get; set; }
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
