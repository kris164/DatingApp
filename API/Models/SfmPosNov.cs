using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmPosNov
    {
        public int IdSfmPos { get; set; }
        /// <summary>
        /// ID systemu w bazie SFM
        /// </summary>
        public short? IdSfmSystem { get; set; }
        /// <summary>
        /// czas UTC pozycji GPS
        /// </summary>
        public DateTime? Gpstime { get; set; }
        /// <summary>
        /// numer modemu
        /// </summary>
        public string Modem { get; set; }
        /// <summary>
        /// waga ładunku
        /// </summary>
        public double? BogieLoad { get; set; }
        /// <summary>
        /// stan naładowania baterii
        /// </summary>
        public double? PwrBattery { get; set; }
        /// <summary>
        /// tryb zasilania (1-External /0-inne)
        /// </summary>
        public short? PwrMode { get; set; }
        /// <summary>
        /// stan zasilania P1
        /// </summary>
        public double? PwrP1 { get; set; }
        /// <summary>
        /// stan zasilania P2
        /// </summary>
        public double? PwrP2 { get; set; }
    }
}
