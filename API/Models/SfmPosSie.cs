using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmPosSie
    {
        public int IdSfmPos { get; set; }
        /// <summary>
        /// ID systemu w bazie SFM
        /// </summary>
        public int? IdSfmSystem { get; set; }
        public long? Recid { get; set; }
        public int? Vehid { get; set; }
        public int? Driverid { get; set; }
        public DateTime? Gpstime { get; set; }
        public short? Satellites { get; set; }
        public int? Altitude { get; set; }
        public int? Distance { get; set; }
        public double? Hdop { get; set; }
    }
}
