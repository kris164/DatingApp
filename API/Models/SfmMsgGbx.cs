using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmMsgGbx
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
        /// GBX - unikalny identyfikator wiadomości
        /// </summary>
        public int? Recid { get; set; }
        /// <summary>
        /// GBX - unikalny identyfikator wiadomości
        /// </summary>
        public long? Extid { get; set; }
    }
}
