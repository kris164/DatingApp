using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Pozycje obsługi akumulatorów
    /// </summary>
    public partial class TaborAkumObsl
    {
        public int IdTaborAkumObsl { get; set; }
        /// <summary>
        /// Relacja do akumulatora - tab: TABOR_AKUM
        /// </summary>
        public int TaborAkumId { get; set; }
        /// <summary>
        /// Relacja do pojazdu - tab: TABOR
        /// </summary>
        public int? TaborId { get; set; }
        /// <summary>
        /// Nr rejestracyjny pojazdu
        /// </summary>
        public string Tabor { get; set; }
        /// <summary>
        /// Typ obsługi
        /// </summary>
        public string TypObsl { get; set; }
        /// <summary>
        /// Data zdarzenia
        /// </summary>
        public DateTime? Data { get; set; }
        /// <summary>
        /// Godzina zdarzenia
        /// </summary>
        public DateTime? Godz { get; set; }
        /// <summary>
        /// Licznik pojazdu w momencie zdarzenia
        /// </summary>
        public double? Licznik { get; set; }
        /// <summary>
        /// Napięcie
        /// </summary>
        public double? Napiecie { get; set; }
        /// <summary>
        /// Gęstość elektrolitu
        /// </summary>
        public double? Gestosc { get; set; }
        /// <summary>
        /// Dowolne uwagi do zdarzenia
        /// </summary>
        public string Uwagi { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int? KontrahId { get; set; }
        /// <summary>
        /// Symbol kontrahenta
        /// </summary>
        public string Kontrah { get; set; }
        /// <summary>
        /// Numer boczny pojazdu
        /// </summary>
        public string TaborNrB { get; set; }
    }
}
