using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// ZDARZENIA DO OBIEKTÓW
    /// </summary>
    public partial class Zdarzenium
    {
        public int IdZdarzenia { get; set; }
        public string Typ { get; set; }
        public int? RecType { get; set; }
        public int? TaborId { get; set; }
        public string Tabor { get; set; }
        public int? AdrId { get; set; }
        public string AdrUlica { get; set; }
        public string AdrMiejsc { get; set; }
        public string AdrKod { get; set; }
        public string AdrKraj { get; set; }
        public double? AdrLon { get; set; }
        public double? AdrLat { get; set; }
        public DateTime? DtStart { get; set; }
        public DateTime? DtStaytime { get; set; }
        public DateTime? DtRealStart { get; set; }
        public DateTime? DtRealStaytime { get; set; }
        public int? ZlecenieId { get; set; }
        public string Zlecenie { get; set; }
        public int? WyjazdId { get; set; }
        public string Wyjazd { get; set; }
        public int? ListLiniowyId { get; set; }
        public string ListLiniowy { get; set; }
        public int? Lp { get; set; }
        public double? Waga { get; set; }
        public string JednWagi { get; set; }
        public double? Licznik { get; set; }
        public double? Ilosc { get; set; }
        public string Jm { get; set; }
        public string InneUwagi { get; set; }
        public short? Automat { get; set; }
        public int? Geocode { get; set; }
        /// <summary>
        /// typ obiektu SPEED
        /// </summary>
        public int? IdObj { get; set; }
        /// <summary>
        /// id obiektu SPEED (patrz ID_OBJ)
        /// </summary>
        public int? IdRec { get; set; }
    }
}
