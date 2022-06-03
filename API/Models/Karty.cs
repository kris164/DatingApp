using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Karty paliwowe zarejestrowane w systemie
    /// </summary>
    public partial class Karty
    {
        public int IdKarty { get; set; }
        /// <summary>
        /// Lp
        /// </summary>
        public int? Lp { get; set; }
        /// <summary>
        /// Symbol karty z tabeli KARTY_WYDAWCY
        /// </summary>
        public string Typ { get; set; }
        /// <summary>
        /// Numer karty
        /// </summary>
        public string Numer { get; set; }
        /// <summary>
        /// Relacja do pojazdu - tab: TABOR
        /// </summary>
        public int? TaborId { get; set; }
        /// <summary>
        /// Nr rejestracyjny pojazdu
        /// </summary>
        public string Tabor { get; set; }
        /// <summary>
        /// Data ważności od
        /// </summary>
        public DateTime? DataWaznosciOd { get; set; }
        /// <summary>
        /// Data ważności do
        /// </summary>
        public DateTime? DataWaznosciDo { get; set; }
        /// <summary>
        /// Status karty: AK-Aktywna, PT-Po terminie ważności, ZG-Zagubiona, ZN-Zniszczona, ZS-Zastrzeżona, TN-Tymczasowo nieuzywana
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// Limit gotówkowy
        /// </summary>
        public double? Limit { get; set; }
        /// <summary>
        /// Dowolne uwagi do karty
        /// </summary>
        public string Uwagi { get; set; }
        /// <summary>
        /// Relacja do kierowcy - tab: KIEROWCY
        /// </summary>
        public int? KierowcaId { get; set; }
        /// <summary>
        /// Nazwisko i imię kierowcy
        /// </summary>
        public string Kierowca { get; set; }
        /// <summary>
        /// *pole nie używane*
        /// </summary>
        public string Pin { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Limit paliwa
        /// </summary>
        public double? LimitPaliwa { get; set; }
        /// <summary>
        /// Flaga, czy karta na okaziciela
        /// </summary>
        public int? NaOkaziciela { get; set; }
        /// <summary>
        /// Flaga, czy karta przydzielana do kierowców
        /// </summary>
        public int? Przydzielana { get; set; }
    }
}
