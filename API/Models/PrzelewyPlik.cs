using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PrzelewyPlik
    {
        public int IdPrzelewyPlik { get; set; }
        public string Nr { get; set; }
        public int? NrKolejny { get; set; }
        public int? NrRok { get; set; }
        public int? NrMies { get; set; }
        public int? TypPliku { get; set; }
        public int? PrzelewyRachunkiId { get; set; }
        public string Bank { get; set; }
        public string Nazwa { get; set; }
        public string Numer { get; set; }
        public string Waluta { get; set; }
        public int? IloscOper { get; set; }
        public double? SumaOper { get; set; }
        public DateTime? DataUtworzenia { get; set; }
        public DateTime? GodzUtworzenia { get; set; }
        public DateTime? DataWyslania { get; set; }
        public DateTime? GodzWyslania { get; set; }
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
        public int? Zagr { get; set; }
        public string KrajIban { get; set; }
        public DateTime? DataWygenerPliku { get; set; }
        public DateTime? GodzWygenerPliku { get; set; }
        public DateTime? DataRealizacji { get; set; }
        public int? TrybRealizacji { get; set; }
    }
}
