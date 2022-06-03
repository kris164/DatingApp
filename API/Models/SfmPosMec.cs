using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmPosMec
    {
        public int IdSfmPos { get; set; }
        /// <summary>
        /// ID systemu w bazie SFM
        /// </summary>
        public short? IdSfmSystem { get; set; }
        /// <summary>
        /// MEC - unikalny identyfikator pozycji
        /// </summary>
        public long? Recid { get; set; }
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
