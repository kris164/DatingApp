using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SzablonyZlecenPowiadomienium
    {
        public int IdSzablonyZlecenPowiadomienia { get; set; }
        public int? SzablonyZlecenId { get; set; }
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
        /// Treść komunikatu
        /// </summary>
        public string Tresc { get; set; }
    }
}
