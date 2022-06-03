using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Lista dni w roku z infomracja jaki jest to dzien
    /// </summary>
    public partial class Kalendarz
    {
        public int IdKalendarz { get; set; }
        /// <summary>
        /// Symbol kraju
        /// </summary>
        public string Kraj { get; set; }
        /// <summary>
        /// Typ dnia 0 - roboczy, 1 - Wolny, 2 - Niedziela, 3 - Swieto
        /// </summary>
        public int? Typ { get; set; }
        /// <summary>
        /// Data
        /// </summary>
        public DateTime? Data { get; set; }
        /// <summary>
        /// Numer roku
        /// </summary>
        public int? Rok { get; set; }
        /// <summary>
        /// Numer miesiaca
        /// </summary>
        public int? Miesiac { get; set; }
        /// <summary>
        /// Numer dnia w miesiacu
        /// </summary>
        public int? Dzien { get; set; }
        /// <summary>
        /// Numer tygodnia
        /// </summary>
        public int? Tydzien { get; set; }
        /// <summary>
        /// Numer dnia tygodnia 1 - Poniedzialek, ..., 7 - Niedziela
        /// </summary>
        public int? DzienTygodnia { get; set; }
        /// <summary>
        /// Numer dnia w roku
        /// </summary>
        public int? DzienRoku { get; set; }
        /// <summary>
        /// Nazwa uzytkownika tworzacego rekord
        /// </summary>
        public string Opis { get; set; }
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
        /// <summary>
        /// Wyjątek
        /// </summary>
        public int? Wyjatek { get; set; }
        /// <summary>
        /// Strefa kodowa dla wyjątku
        /// </summary>
        public int? KodStrefaId { get; set; }
        public int? TrafficLimit { get; set; }
        public DateTime? TrafficLimitFrom { get; set; }
        public DateTime? TrafficLimitTo { get; set; }
        public DateTime? TrafficLimit2From { get; set; }
        public DateTime? TrafficLimit2To { get; set; }
        public int? TrafficLimitProvince { get; set; }
        public string TrafficLimitProvinceList { get; set; }
        public int? TrafficLimitProvince2 { get; set; }
        public string TrafficLimitProvince2List { get; set; }
        public string TrafficLimitType { get; set; }
    }
}
