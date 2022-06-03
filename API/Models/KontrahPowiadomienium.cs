using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class KontrahPowiadomienium
    {
        public int IdKontrahPowiadomienia { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int KontrahId { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: OBJECT
        /// </summary>
        public int ObjId { get; set; }
        /// <summary>
        /// Do kogo np. ZLEC, NAD, ODB, PLATN, PARTN, INNY
        /// </summary>
        public string Kto { get; set; }
        /// <summary>
        /// Typ powiadomienia np. SMS, EMAIL etc
        /// </summary>
        public string Typ { get; set; }
        /// <summary>
        /// Statusy wyzwalające zapisane jako ciąg rozdzielany ;
        /// </summary>
        public string CoWyzwala { get; set; }
        /// <summary>
        /// Adres email na jaki zostanie wysłane powiadomienie
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Symbol kraju
        /// </summary>
        public string Kraj { get; set; }
        /// <summary>
        /// Prefix telefonu
        /// </summary>
        public string TelPrefix { get; set; }
        /// <summary>
        /// Nr telefonu
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// Treść komunikatu
        /// </summary>
        public string Tresc { get; set; }
        /// <summary>
        /// Dotyczy lokalizacji
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Dotyczy działu
        /// </summary>
        public string Dzial { get; set; }
    }
}
