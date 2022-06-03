using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmTerm
    {
        public int IdSfmTerm { get; set; }
        public short? Wylacz { get; set; }
        public int IdTabor { get; set; }
        public int IdSfmTabor { get; set; }
        public string Id { get; set; }
        public string Numer { get; set; }
        public string Opis { get; set; }
        /// <summary>
        /// ID systemu telematycznego
        /// </summary>
        public int? IdSfmSystem { get; set; }
        public string TypTerm { get; set; }
        public string Operator { get; set; }
        public DateTime? Startarch { get; set; }
        public int? MaxCzasPobrania { get; set; }
        public string Algorytm { get; set; }
        public int? IdSfmPos { get; set; }
        public string Miejsce { get; set; }
        public int? Status { get; set; }
        public DateTime? RejCzas { get; set; }
        public short? RejCiagla { get; set; }
        public int? RejDelta { get; set; }
        public short? Msgdsm { get; set; }
        public string TerminalIp { get; set; }
        public int? TerminalPort { get; set; }
        public short? CopyOdo2lkm { get; set; }
        public int? IdKierowcy { get; set; }
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
        public short? Nomessages { get; set; }
        public short? PtoWebasto { get; set; }
        public string NumerExt { get; set; }
    }
}
