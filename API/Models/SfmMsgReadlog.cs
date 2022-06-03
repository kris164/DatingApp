using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmMsgReadlog
    {
        public int IdSfmMsgReadlog { get; set; }
        /// <summary>
        /// id wiadomości
        /// </summary>
        public int? IdSfmMsg { get; set; }
        /// <summary>
        /// id dyspozytora
        /// </summary>
        public int? IdUzytk { get; set; }
        /// <summary>
        /// nazwisko dyspozytora
        /// </summary>
        public string Nazwauzytk { get; set; }
        /// <summary>
        /// czas przeczytania wiadomości
        /// </summary>
        public DateTime? DtPrzeczyt { get; set; }
    }
}
