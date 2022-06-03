using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PrzelewyCelne
    {
        public int IdPrzelewyCelne { get; set; }
        public string NrPrzelewu { get; set; }
        public int? NrPrzelewuKolejny { get; set; }
        public int? NrPrzelewuRok { get; set; }
        public int? NrPrzelewuMies { get; set; }
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
        public DateTime? DataPlatnosci { get; set; }
        public DateTime? DataZwolnienia { get; set; }
        public int? Zaplacone { get; set; }
        public DateTime? ZaplaconeData { get; set; }
        public int? IzbaId { get; set; }
        public string IzbaCelna { get; set; }
        public string IzbaNazwa { get; set; }
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
