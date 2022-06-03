using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Usługi inne - detal do tabeli ZLECENIA
    /// </summary>
    public partial class ZleceniaOthPoz
    {
        public int IdZleceniaOthPoz { get; set; }
        /// <summary>
        /// Relacja do zlecenia - tab: ZLECENIA lub inne
        /// </summary>
        public int ZlecenieId { get; set; }
        /// <summary>
        /// typ zlecenia ZC - Celne
        /// </summary>
        public string Typ { get; set; }
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
