using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmMsgSet
    {
        public int IdSfmMsg { get; set; }
        /// <summary>
        /// ID systemu w bazie SFM
        /// </summary>
        public short? IdSfmSystem { get; set; }
        /// <summary>
        /// czas UTC wiadomości
        /// </summary>
        public DateTime? Gpstime { get; set; }
        /// <summary>
        /// SET - unikalny identyfikator wiadomości
        /// </summary>
        public long? Extid { get; set; }
    }
}
