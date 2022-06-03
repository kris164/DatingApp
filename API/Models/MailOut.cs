using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Poczta wychodzaca (E-Mail integrator)
    /// </summary>
    public partial class MailOut
    {
        public int IdMailOut { get; set; }
        /// <summary>
        /// Typ wiadomości: ZLECENIE,TABOR,PRZESYLKI etc.
        /// </summary>
        public string MailType { get; set; }
        /// <summary>
        /// Data wysłania
        /// </summary>
        public DateTime? DateOut { get; set; }
        /// <summary>
        /// Godzina wysłania
        /// </summary>
        public DateTime? TimeOut { get; set; }
        /// <summary>
        /// Temat wiadomości
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// Adres nadawcy
        /// </summary>
        public string MailFrom { get; set; }
        /// <summary>
        /// Adres odbiorcy
        /// </summary>
        public string MailTo { get; set; }
        /// <summary>
        /// Treść wiadomości
        /// </summary>
        public string MailBody { get; set; }
        /// <summary>
        /// Użytkownik wysyłający
        /// </summary>
        public string UserSend { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Dział
        /// </summary>
        public string Dzial { get; set; }
        /// <summary>
        /// Relacja do obiektu - zależna od typu wiadomości
        /// </summary>
        public int? ObjId { get; set; }
        /// <summary>
        /// Numer obiektu wyeksportowanego
        /// </summary>
        public string Obj { get; set; }
        /// <summary>
        /// Wersja EMI
        /// </summary>
        public int? EmiVer { get; set; }
        /// <summary>
        /// Plik XML
        /// </summary>
        public int? EmiXmlId { get; set; }
    }
}
