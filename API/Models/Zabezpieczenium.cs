using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Zabezpieczenium
    {
        public int IdZabezpieczenia { get; set; }
        public string Numer { get; set; }
        public string Rodzaj { get; set; }
        public int? Aktywne { get; set; }
        public DateTime? Waznedo { get; set; }
        public double? Kwota { get; set; }
        public double? Obciazenie { get; set; }
        public double? Wolna { get; set; }
        public double? ObciazenieMaks { get; set; }
        public int? KontrahId { get; set; }
        public int? Zalaczniki { get; set; }
        public string Lokalizacja { get; set; }
        public string Opis { get; set; }
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
        public string Dzial { get; set; }
    }
}
