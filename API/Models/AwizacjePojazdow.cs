using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class AwizacjePojazdow
    {
        public int IdAwizacjePojazdow { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Godz { get; set; }
        public string Kraj { get; set; }
        public string Kod { get; set; }
        public string Miasto { get; set; }
        public string Adres { get; set; }
        public double? GeoLon { get; set; }
        public double? GeoLat { get; set; }
        public int? PrzewoznikId { get; set; }
        public string Przewoznik { get; set; }
        public string PrzewoznikTel1 { get; set; }
        public string PrzewoznikTel2 { get; set; }
        public int? SamochodId { get; set; }
        public string Samochod { get; set; }
        public int? NaczepaId { get; set; }
        public string Naczepa { get; set; }
        public int? Stan { get; set; }
        public string PrefKier { get; set; }
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
    }
}
