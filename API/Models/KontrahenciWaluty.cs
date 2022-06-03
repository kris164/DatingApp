using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Dozwolone waluty dla kontrahenta
    /// </summary>
    public partial class KontrahenciWaluty
    {
        public int IdKontrahenciWaluty { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int KontrahId { get; set; }
        /// <summary>
        /// Kod waluty
        /// </summary>
        public string Waluta { get; set; }
        /// <summary>
        /// Typ P - przychód, K - koszt
        /// </summary>
        public string Typ { get; set; }
        /// <summary>
        /// Konto FK
        /// </summary>
        public string KontoFk { get; set; }
        /// <summary>
        /// Termin płatności dla waluty
        /// </summary>
        public int? TerminPlatnosci { get; set; }
        /// <summary>
        /// Status dla waluty
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// Limit kredytu dla waluty
        /// </summary>
        public double? LimitKred { get; set; }
        /// <summary>
        /// Dotyczy lokalizacji lub *
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Dotyczy działu lub *
        /// </summary>
        public string Dzial { get; set; }
    }
}
