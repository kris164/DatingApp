using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// powiadomienia w kontekście obiektu SPEED
    /// </summary>
    public partial class SfmNotify
    {
        public int IdSfmNotify { get; set; }
        /// <summary>
        /// relacja do utworzonej wiadomości
        /// </summary>
        public int? IdSfmMsg { get; set; }
        /// <summary>
        /// typ obiektu SPEED
        /// </summary>
        public int? ObjTyp { get; set; }
        /// <summary>
        /// relacja do obiektu SPEED
        /// </summary>
        public int? ObjId { get; set; }
        /// <summary>
        /// EML: źródło danych o serwerze mailowym (/U-użytkownik /L-lokalizacja /S-system)
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
        /// typ powiadomienia SMS/EML/...
        /// </summary>
        public string MsgType { get; set; }
        /// <summary>
        /// nr telefonu. lub adres e-mail na jaki zostanie wysłane powiadomienie
        /// </summary>
        public string MsgAddress { get; set; }
        /// <summary>
        /// temat wiadomości EML
        /// </summary>
        public string MsgSubject { get; set; }
        /// <summary>
        /// treść wiadomości
        /// </summary>
        public string MsgBody { get; set; }
        /// <summary>
        /// data utworzenia powiadomoenia
        /// </summary>
        public DateTime? DtCreate { get; set; }
        /// <summary>
        /// id dyspozytora
        /// </summary>
        public int? IdUzytk { get; set; }
        /// <summary>
        /// nazwisko dyspozytora
        /// </summary>
        public string Nazwauzytk { get; set; }
        /// <summary>
        /// kod lokalizacji
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// kod działu
        /// </summary>
        public string Dzial { get; set; }
    }
}
