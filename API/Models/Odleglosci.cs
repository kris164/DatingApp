using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Macież odległości między POI-ami
    /// </summary>
    public partial class Odleglosci
    {
        public int IdOdleglosci { get; set; }
        public int? MiejsceAId { get; set; }
        public string MiejsceA { get; set; }
        public string KrajA { get; set; }
        public string MiastoA { get; set; }
        public string KodA { get; set; }
        public double? LonA { get; set; }
        public double? LatA { get; set; }
        public int? MiejsceBId { get; set; }
        public string MiejsceB { get; set; }
        public string KrajB { get; set; }
        public string MiastoB { get; set; }
        public string KodB { get; set; }
        public double? LonB { get; set; }
        public double? LatB { get; set; }
        public double? Odleglosc { get; set; }
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
        public double? OdlegloscLin { get; set; }
        public int? Czas { get; set; }
    }
}
