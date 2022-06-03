using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Usługi inne - detal do tabeli PRZESYLKI
    /// </summary>
    public partial class PrzesylkiOthPoz
    {
        public int IdPrzesylkiOthPoz { get; set; }
        /// <summary>
        /// Relacja do przesyłki - tab: PRZESYLKI
        /// </summary>
        public int PrzesylkiId { get; set; }
        /// <summary>
        /// Lp
        /// </summary>
        public int? Lp { get; set; }
        public double? Ilosc { get; set; }
        /// <summary>
        /// Relacja do słownika pozycji - tab: OTH_POZ
        /// </summary>
        public int? OthPozId { get; set; }
        public string OpisDod { get; set; }
        public string Uwagi { get; set; }
        public DateTime? Data { get; set; }
    }
}
