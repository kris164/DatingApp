using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmMsgEml
    {
        public int IdSfmMsg { get; set; }
        /// <summary>
        /// ID systemu w bazie SFM
        /// </summary>
        public int? IdSfmSystem { get; set; }
        /// <summary>
        /// adres nadawcy/odbiorcy
        /// </summary>
        public string Mail { get; set; }
        /// <summary>
        /// EML: źródło danych o serwerze mailowym (/U-użytkownik /L-lokalizacja /S-system /{empty}-default )
        /// </summary>
        public string SenderTyp { get; set; }
        /// <summary>
        /// EML: relacja do odpowiedniej tabeli zawierającej źródło danych o serwerze mailowym
        /// </summary>
        public int? SenderId { get; set; }
        /// <summary>
        /// 0/1 - wyślij kopię do nadawcy
        /// </summary>
        public short? Copytosender { get; set; }
        /// <summary>
        /// ID wiadomości wysyłanej przez DBMAIL
        /// </summary>
        public int? DbmailMailitemId { get; set; }
    }
}
