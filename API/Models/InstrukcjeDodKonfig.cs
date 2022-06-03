using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class InstrukcjeDodKonfig
    {
        public int IdInstrukcjeDodKonfig { get; set; }
        public string Typ { get; set; }
        public int? InstrukcjeDodId { get; set; }
        public string Kod { get; set; }
        public int? KlientId { get; set; }
        public string Klient { get; set; }
        public string TypZlecenia { get; set; }
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
        public int? MiejsceZaId { get; set; }
        public string MiejsceZa { get; set; }
        public int? Wymagana { get; set; }
        public int? Stdwyl { get; set; }
        public int? Nstdwl { get; set; }
        public DateTime? NstdwlDataod { get; set; }
        public DateTime? NstdwlDatado { get; set; }
        public string CennikPodstawa { get; set; }
        public int? CennikKalkulacja { get; set; }
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
