using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmMsgQfv
    {
        public int IdSfmMsg { get; set; }
        /// <summary>
        /// ID systemu w bazie SFM
        /// </summary>
        public short? IdSfmSystem { get; set; }
        /// <summary>
        /// QFV - unikalny identyfikator wiadomości
        /// </summary>
        public long? Recid { get; set; }
        /// <summary>
        /// ID terminala
        /// </summary>
        public string Vehid { get; set; }
        /// <summary>
        /// czas UTC wiadomości
        /// </summary>
        public DateTime? Gpstime { get; set; }
    }
}
