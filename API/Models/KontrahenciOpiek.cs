using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Przypisanie kontrahenta do opiekunów
    /// </summary>
    public partial class KontrahenciOpiek
    {
        public int IdKontrahenciOpiek { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int? KontrahId { get; set; }
        /// <summary>
        /// Typ opiekuna OH, OB
        /// </summary>
        public string Kind { get; set; }
        /// <summary>
        /// Relacja do opiekuna - tab: UZYTKOWNICY
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Relacja do typu - tab: KONTRAH_TYP_REPREZ
        /// </summary>
        public int? ReptypeId { get; set; }
        /// <summary>
        /// Flaga, czy domyślny
        /// </summary>
        public int? Def { get; set; }
        /// <summary>
        /// Dotyczy lokalizacji
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Dotyczy działu
        /// </summary>
        public string Dzial { get; set; }
        /// <summary>
        /// Rejon
        /// </summary>
        public string Rejon { get; set; }
        /// <summary>
        /// Kod
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// Data od
        /// </summary>
        public DateTime? DtFrom { get; set; }
        /// <summary>
        /// Data do
        /// </summary>
        public DateTime? DtTo { get; set; }
    }
}
