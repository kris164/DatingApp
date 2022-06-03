using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmPosPnc
    {
        public int IdSfmPos { get; set; }
        /// <summary>
        /// ID systemu w bazie SFM
        /// </summary>
        public int? IdSfmSystem { get; set; }
        /// <summary>
        /// czas z pozycji GPS
        /// </summary>
        public DateTime? Gpstime { get; set; }
        /// <summary>
        /// identyfikator kierowcy
        /// </summary>
        public string Driverid { get; set; }
        /// <summary>
        /// identyfikator terminala
        /// </summary>
        public string Vehid { get; set; }
        /// <summary>
        /// typ aktywności
        /// </summary>
        public int? Tracetype { get; set; }
        /// <summary>
        /// identyfikator naczepy
        /// </summary>
        public string Traid { get; set; }
        /// <summary>
        /// typ obiektu SPEED
        /// </summary>
        public int? IdObj { get; set; }
        /// <summary>
        /// id obiektu SPEED
        /// </summary>
        public int? IdRec { get; set; }
        /// <summary>
        /// poziom paliwa w zbiorniku pojazdu [L]
        /// </summary>
        public double? Fla { get; set; }
    }
}
