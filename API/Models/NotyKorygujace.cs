using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class NotyKorygujace
    {
        public int IdNotyKorygujace { get; set; }
        public string Numer { get; set; }
        public int? NumerKolejny { get; set; }
        public int? NumerRok { get; set; }
        public int? NumerMies { get; set; }
        public DateTime? Data { get; set; }
        public int? FakturaId { get; set; }
        public string Faktura { get; set; }
        public int? FakturaOtrzymana { get; set; }
        public int? TeczkaId { get; set; }
        public string Teczka { get; set; }
        public int? KontrahId { get; set; }
        public string KontrahSymbol { get; set; }
        public string KontrahNazwa { get; set; }
        public string KontrahAdres { get; set; }
        public string KontrahMiasto { get; set; }
        public string KontrahKod { get; set; }
        public string KontrahKraj { get; set; }
        public string KontrahNip { get; set; }
        public string RodzajNoty { get; set; }
        public string Tresc { get; set; }
        public string TrescPo { get; set; }
        public string Lokalizacja { get; set; }
        public int? LOrg { get; set; }
        public int? LKop { get; set; }
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
        public int? TrafikId { get; set; }
        public string Trafik { get; set; }
        public DateTime? DataPotw { get; set; }
        public string Dzial { get; set; }
        public int? OddzialId { get; set; }
        public string OddzialNazwa { get; set; }
        public string OddzialAdres { get; set; }
        public string OddzialMiasto { get; set; }
        public string OddzialKod { get; set; }
        public string OddzialKraj { get; set; }
        public string Uwagi { get; set; }
        /// <summary>
        /// Informacje od opiekuna
        /// </summary>
        public string InfoOpiekuna { get; set; }
    }
}
