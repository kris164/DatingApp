using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ZabezpieczeniaPoz
    {
        public int IdZabezpieczeniaPoz { get; set; }
        public int? ZabezpieczenieId { get; set; }
        public int? ZlecenieId { get; set; }
        public double? KwotaVat { get; set; }
        public double? KwotaClo { get; set; }
        public double? KwotaInne { get; set; }
        public double? Kwota { get; set; }
        public int? Zaplacone { get; set; }
        public DateTime? ZaplaconeData { get; set; }
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
        public int? Anulowane { get; set; }
        public double? Zaplacono { get; set; }
        public double? KwotaB00 { get; set; }
        public double? KwotaA00 { get; set; }
        public double? KwotaA10 { get; set; }
        public double? Kwota1a1 { get; set; }
    }
}
