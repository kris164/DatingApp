using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Poczta przychodząca (E-Mail integrator)
    /// </summary>
    public partial class MailIn
    {
        public int IdMailIn { get; set; }
        /// <summary>
        /// Identyfikator wiadomości z klienta pocztowego
        /// </summary>
        public string MailId { get; set; }
        /// <summary>
        /// Typ wiadomości: ZLECENIE,TABOR,PRZESYLKI etc.
        /// </summary>
        public string MailType { get; set; }
        /// <summary>
        /// Data odbioru
        /// </summary>
        public DateTime? DateIn { get; set; }
        /// <summary>
        /// Godzina odbioru
        /// </summary>
        public DateTime? TimeIn { get; set; }
        /// <summary>
        /// Temat
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
        /// Relacja do obiektu jaki został utworzony z wiadomości
        /// </summary>
        public int? ObjectId { get; set; }
        /// <summary>
        /// Numer obiektu utworzonego z wiadomości
        /// </summary>
        public string Object { get; set; }
        /// <summary>
        /// Lokalizacja PSD
        /// </summary>
        public string Localization { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Dział
        /// </summary>
        public string Dzial { get; set; }
        /// <summary>
        /// Znacznik, czy duplikat wiadomości
        /// </summary>
        public int? Duplikat { get; set; }
        /// <summary>
        /// Znacznik, czy utworzono obiekt z wiadomości
        /// </summary>
        public int? Wczytany { get; set; }
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
