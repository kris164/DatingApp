using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WydrukiStatus
    {
        public int IdWydrukiStatus { get; set; }
        public int? ObiektId { get; set; }
        public string ObiektTyp { get; set; }
        public string Zdarzenie { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Godz { get; set; }
        public int? UzytkownikId { get; set; }
        public string Uzytkownik { get; set; }
        public int? KontrahId { get; set; }
        public string KontrahSymbol { get; set; }
        public string AdresyEmail { get; set; }
        public string Uwagi { get; set; }
        public string FormatkaRpt { get; set; }
        public string Powod { get; set; }
        public string ObjTyp { get; set; }
        public int? ObjId { get; set; }
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
