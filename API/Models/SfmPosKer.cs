using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmPosKer
    {
        public int IdSfmPos { get; set; }
        /// <summary>
        /// ID systemu w bazie SFM
        /// </summary>
        public int? IdSfmSystem { get; set; }
        public long? Recid { get; set; }
        public long? Objid { get; set; }
        public DateTime? Gpstime { get; set; }
        public short? Gpssatnum { get; set; }
        public short? Gpsdir { get; set; }
        public string Gpsstatus { get; set; }
        public int? Sensorbin { get; set; }
        public string Alarmstate { get; set; }
    }
}
