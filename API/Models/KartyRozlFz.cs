using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Nagłówke rozliczenia faktur zbiorczych
    /// </summary>
    public partial class KartyRozlFz
    {
        public int IdKartyRozlFz { get; set; }
        /// <summary>
        /// Relacja do faktury zbiorczej - tab: FAKTURY
        /// </summary>
        public int? FakturaId { get; set; }
        /// <summary>
        /// Numer faktury
        /// </summary>
        public string Faktura { get; set; }
        /// <summary>
        /// Typ karty
        /// </summary>
        public string KartaTyp { get; set; }
        /// <summary>
        /// Data poczatkowa okresu
        /// </summary>
        public DateTime? DataOd { get; set; }
        /// <summary>
        /// Data końcowa okresu
        /// </summary>
        public DateTime? DataDo { get; set; }
        /// <summary>
        /// Status rozliczenia: 0 - utworzone, 1 - w trakcie uzgadniania, 2- zgodne, 3 - niezgodne
        /// </summary>
        public int? Status { get; set; }
        /// <summary>
        /// Dowolne uwagi do rozliczenia
        /// </summary>
        public string Uwagi { get; set; }
    }
}
