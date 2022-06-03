using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmPosSet
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
        /// SET - unikalny identyfikator pozycji
        /// </summary>
        public long? Extid { get; set; }
    }
}
