using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ZleceniaRailPowiadomienium
    {
        public int IdZleceniaRailPowiadomienia { get; set; }
        /// <summary>
        /// Relacja do zlecenia, tab: ZLECENIA_RAIL_ID
        /// </summary>
        public int? ZleceniaRailId { get; set; }
        /// <summary>
        /// Do kogo np. ZLEC, PLATN, PRZEWOZNIK, INNY
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
        /// Data utworzenia powiadomoenia (=ZLECENIA.DATA_ZLECENIA)
        /// </summary>
        public DateTime? Data { get; set; }
        /// <summary>
        /// Data/Godzina wyzwolenia powiadomienia
        /// </summary>
        public DateTime? Dt { get; set; }
        /// <summary>
        /// Treść komunikatu
        /// </summary>
        public string Tresc { get; set; }
    }
}
