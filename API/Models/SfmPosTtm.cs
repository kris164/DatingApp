using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmPosTtm
    {
        public int IdSfmPos { get; set; }
        /// <summary>
        /// ID systemu w bazie SFM
        /// </summary>
        public int? IdSfmSystem { get; set; }
        /// <summary>
        /// unikalny identyfikator pozycji
        /// </summary>
        public long? Recid { get; set; }
        /// <summary>
        /// identyfikator kierowcy
        /// </summary>
        public string Driverid { get; set; }
        /// <summary>
        /// identyfikator terminala
        /// </summary>
        public string Vehid { get; set; }
        /// <summary>
        /// czas UTC z pozycji GPS
        /// </summary>
        public DateTime? Gpstime { get; set; }
        /// <summary>
        /// 0-Unknown/ 1-Private /2-Business /3-Way-to-work /4-Correction
        /// </summary>
        public short? Tripmode { get; set; }
        /// <summary>
        /// 0-unknown /1-system /2-text /3-polling /4-timer event /5-gps event /6-input event /7-set output /8-data /9-configuration /10-trip /11-order
        /// </summary>
        public short? Msgclass { get; set; }
    }
}
