using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TeczkiRap
    {
        public int IdTeczkiRap { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public int? TrafikId { get; set; }
        public string Trafik { get; set; }
        public int? TeczkaId { get; set; }
        public string Teczka { get; set; }
        public string Lokalizacja { get; set; }
        public int? Wg { get; set; }
        public DateTime? DataOd { get; set; }
        public DateTime? DataDo { get; set; }
        public int? Rok { get; set; }
        public int? Miesiac { get; set; }
        public string TeczkaStatus { get; set; }
        public byte[] GridSettings { get; set; }
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
