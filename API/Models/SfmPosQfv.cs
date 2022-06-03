using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmPosQfv
    {
        public int IdSfmPos { get; set; }
        /// <summary>
        /// ID systemu w bazie SFM
        /// </summary>
        public short? IdSfmSystem { get; set; }
        /// <summary>
        /// QFV - unikalny identyfikator pozycji
        /// </summary>
        public long? Recid { get; set; }
        /// <summary>
        /// 0-HTRACS /1-ETA /2-MSG /3-POS /4-TTRACS /5-STRACS
        /// </summary>
        public short? Recreftype { get; set; }
        /// <summary>
        /// ID terminala
        /// </summary>
        public string Vehid { get; set; }
        /// <summary>
        /// czas UTC pozycji GPS
        /// </summary>
        public DateTime? Gpstime { get; set; }
        /// <summary>
        /// wysokość nad poziomem morza [m]
        /// </summary>
        public int? Altitude { get; set; }
    }
}
