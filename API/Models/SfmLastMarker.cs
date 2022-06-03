using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// rejestrowanie ostatniego znacznika pobierania
    /// </summary>
    public partial class SfmLastMarker
    {
        public int IdSfmLastMarker { get; set; }
        /// <summary>
        /// ID systemu telematycznego
        /// </summary>
        public int IdSfmSystem { get; set; }
        /// <summary>
        /// ID terminala
        /// </summary>
        public int IdSfmTerm { get; set; }
        /// <summary>
        /// typ terminala - kod operatora
        /// </summary>
        public string TypTerm { get; set; }
        /// <summary>
        /// akcja serwera SFM (np. MSG/POS/TACHO/itp.)
        /// </summary>
        public string Action { get; set; }
        /// <summary>
        /// marker pobierania danych telematycznych
        /// </summary>
        public string Marker { get; set; }
        /// <summary>
        /// marker pobierania danych telematycznych
        /// </summary>
        public short? Isactive { get; set; }
        /// <summary>
        /// data rejestracji
        /// </summary>
        public DateTime? Dt { get; set; }
    }
}
