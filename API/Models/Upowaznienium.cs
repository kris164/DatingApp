using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Upowaznienium
    {
        public int IdUpowaznienia { get; set; }
        public string NrUpowaznienia { get; set; }
        public int? NrUpowaznieniaKolejny { get; set; }
        public int? NrUpowaznieniaRok { get; set; }
        public int? NrUpowaznieniaMies { get; set; }
        public int? Wazne { get; set; }
        public int? KontrahId { get; set; }
        public int? OsobaKontaktowaId { get; set; }
        public string OsobaKontaktowa { get; set; }
        public string OsobaMail { get; set; }
        public string OsobaTelefon { get; set; }
        public DateTime? DataPrzyjecia { get; set; }
        public DateTime? DataWystawienia { get; set; }
        public DateTime? RodzajData { get; set; }
        public int? Rodzaj { get; set; }
        public string RodzajNumer { get; set; }
        public int? RodzajId { get; set; }
        public int? Typ { get; set; }
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
        public string KontrahSymbol { get; set; }
        public string Ias { get; set; }
        public int? Oplata { get; set; }
        public int? Oryginal { get; set; }
    }
}
