using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RhenusRozlTrasPoz
    {
        public int IdRhenusRozlTrasPoz { get; set; }
        public int? Lp { get; set; }
        public int? RhenusRozlTrasId { get; set; }
        public int? ListyLinioweId { get; set; }
        public int? Rozliczona { get; set; }
        public string Faktura { get; set; }
        public int? FakturaId { get; set; }
        public int? ZleceniaId { get; set; }
        public int? ZmianyNaTrasach { get; set; }
        public string WalutaFv { get; set; }
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
