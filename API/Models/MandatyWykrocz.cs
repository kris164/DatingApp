using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MandatyWykrocz
    {
        public int IdMandatyWykrocz { get; set; }
        public int? KierowcaId { get; set; }
        public string Kierowca { get; set; }
        public int? TaborId { get; set; }
        public string Tabor { get; set; }
        public int? Rodzaj { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Godz { get; set; }
        public string Miejsce { get; set; }
        public string Okolicznosci { get; set; }
        public int? Waznosc { get; set; }
        public int? KtoPlaci { get; set; }
        public int? Status { get; set; }
        public double? Kara { get; set; }
        public string KaraWaluta { get; set; }
        public double? KaraPln { get; set; }
        public string Uwagi { get; set; }
        public int? Zalaczniki { get; set; }
        public int? UzytkownikId { get; set; }
        public string Uzytkownik { get; set; }
        public int? NaczepaId { get; set; }
        public string Naczepa { get; set; }
        public int? ZlecenieId { get; set; }
        public string Zlecenie { get; set; }
        public string AktaSprawy { get; set; }
        public string Typ { get; set; }
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
