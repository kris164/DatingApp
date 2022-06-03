using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Lista procedur składowanych
    /// </summary>
    public partial class Procedury
    {
        public int IdProcedury { get; set; }
        /// <summary>
        /// Nazwa procedury
        /// </summary>
        public string Nazwa { get; set; }
        /// <summary>
        /// Grupa 
        /// </summary>
        public string Grupa { get; set; }
        /// <summary>
        /// Tekst procedury
        /// </summary>
        public string Tekst { get; set; }
        /// <summary>
        /// Data utworzenia rekordu
        /// </summary>
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// Czas utworzenia rekordu
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// Id uzytkownika tworzacego rekord
        /// </summary>
        public int? CreateUserId { get; set; }
        /// <summary>
        /// Nazwa uzytkownika tworzacego rekord
        /// </summary>
        public string CreateUserName { get; set; }
        /// <summary>
        /// Data ostatniej modyfikacji rekordu
        /// </summary>
        public DateTime? ModifyDate { get; set; }
        /// <summary>
        /// Czas ostatniej modyfikacji rekordu
        /// </summary>
        public DateTime? ModifyTime { get; set; }
        /// <summary>
        /// Id uzytkownika modyfikujacego rekord
        /// </summary>
        public int? ModifyUserId { get; set; }
        /// <summary>
        /// Nazwa uzytkownika modyfikujacego rekord
        /// </summary>
        public string ModifyUserName { get; set; }
    }
}
