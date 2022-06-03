using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Logi do tworzenia statystyk użytkowania programu
    /// </summary>
    public partial class StatisticsLog
    {
        public int IdStatisticsLog { get; set; }
        /// <summary>
        /// Nazwa aplikacji
        /// </summary>
        public string Appname { get; set; }
        /// <summary>
        /// Wersja aplikacji
        /// </summary>
        public string Appver { get; set; }
        /// <summary>
        /// Relacja do użytkownika - tab: UZYTKOWNIK
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Symbol użytkownika
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Nazwa stacji/komputera
        /// </summary>
        public string StationName { get; set; }
        /// <summary>
        /// IP stacji/komputera
        /// </summary>
        public string StationIp { get; set; }
        /// <summary>
        /// Data pierwszego użycia
        /// </summary>
        public DateTime? UseDtFirst { get; set; }
        /// <summary>
        /// Data ostatniego użycia
        /// </summary>
        public DateTime? UseDtLast { get; set; }
        /// <summary>
        /// Licznik użycia
        /// </summary>
        public int? UseCount { get; set; }
        /// <summary>
        /// Grupa statystyk
        /// </summary>
        public string StatGroup { get; set; }
        /// <summary>
        /// Info (np. nazwa modułu)
        /// </summary>
        public string StatInfo { get; set; }
        /// <summary>
        /// Rezultat testu (np. moduł jest w licencji)
        /// </summary>
        public int? StatResult { get; set; }
    }
}
