using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmPosGbx
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
        /// GBX - unikalny identyfikator pozycji
        /// </summary>
        public long? Extid { get; set; }
    }
}
