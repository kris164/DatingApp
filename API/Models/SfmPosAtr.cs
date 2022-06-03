using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmPosAtr
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
        /// ID pozycji ATROM
        /// </summary>
        public int? Posid { get; set; }
        /// <summary>
        /// ID terminala ATROM
        /// </summary>
        public int? Vehid { get; set; }
        /// <summary>
        /// ID użytkownika ATROM
        /// </summary>
        public int? Usrid { get; set; }
        /// <summary>
        /// Total Fuel Consumption
        /// </summary>
        public double? Tfu { get; set; }
    }
}
