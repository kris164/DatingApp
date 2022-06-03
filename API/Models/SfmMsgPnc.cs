using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmMsgPnc
    {
        public int IdSfmMsg { get; set; }
        /// <summary>
        /// identyfikator wiadomości/zdarzenia
        /// </summary>
        public string Msgid { get; set; }
        /// <summary>
        /// identyfikator terminala
        /// </summary>
        public string Vehid { get; set; }
        /// <summary>
        /// nazwa statusu zdarzenia
        /// </summary>
        public string Taskstate { get; set; }
        /// <summary>
        /// identyfikator wiadomości źródłowej
        /// </summary>
        public string Msgorgid { get; set; }
    }
}
