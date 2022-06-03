using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ListyLiniowePozP
    {
        public int IdListyLiniowePozP { get; set; }
        public int? Lp { get; set; }
        public int? ListyLiniowePozId { get; set; }
        public int? ListyLinioweId { get; set; }
        public int? PrzesylkiId { get; set; }
        public int? PaczkiId { get; set; }
        public int? Skan { get; set; }
        public int? Brak { get; set; }
        public double? AnomaliaOpakIlosc { get; set; }
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
        public int? SkanWy { get; set; }
        public int? BrakWy { get; set; }
        public double? AnomaliaOpakIloscWy { get; set; }
        public int? ZPodlogi { get; set; }
        public string SqlDebugInfo { get; set; }
        public int? Niepodjeta { get; set; }
        public int? Niedoreczona { get; set; }
        public int? NiedoreczonaWina { get; set; }
    }
}
