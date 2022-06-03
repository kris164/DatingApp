using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MapaHistorium
    {
        public int IdMapaHistoria { get; set; }
        /// <summary>
        /// Lista miast na trasie
        /// </summary>
        public string Trasa { get; set; }
        public string Mapa { get; set; }
        public int? Alternatywne { get; set; }
        public double? OdlegloscRazem { get; set; }
        public double? Odleglosc { get; set; }
        public double? Dojazd { get; set; }
        public double? Koszty { get; set; }
        public double? Myto { get; set; }
        public double? KosztyRazem { get; set; }
        public DateTime? Czas { get; set; }
        public string Ustawienia { get; set; }
        /// <summary>
        /// Data utworzenia rekordu
        /// </summary>
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// Czas utworzenia rekordu
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// Id uzytkownika tworzacego rekord
        /// </summary>
        public int? CreateUserId { get; set; }
        /// <summary>
        /// Nazwa uzytkownika tworzacego rekord
        /// </summary>
        public string CreateUserName { get; set; }
        /// <summary>
        /// Data ostatniej modyfikacji rekordu
        /// </summary>
        public DateTime? ModifyDate { get; set; }
        /// <summary>
        /// Czas ostatniej modyfikacji rekordu
        /// </summary>
        public DateTime? ModifyTime { get; set; }
        /// <summary>
        /// Id uzytkownika modyfikujacego rekord
        /// </summary>
        public int? ModifyUserId { get; set; }
        /// <summary>
        /// Nazwa uzytkownika modyfikujacego rekord
        /// </summary>
        public string ModifyUserName { get; set; }
    }
}
