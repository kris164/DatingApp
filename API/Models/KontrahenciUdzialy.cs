using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Definicje udziałów kontrahenta
    /// </summary>
    public partial class KontrahenciUdzialy
    {
        public int IdKontrahenciUdzialy { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int? KontrahId { get; set; }
        /// <summary>
        /// Dotyczy obiektów typu [P]przesyłki, [Z]zlecenia, [T]tasy, [PR]omy
        /// </summary>
        public string Dotyczy { get; set; }
        /// <summary>
        /// Dotyczy lokalizacji lub *
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Dotyczy działu lub *
        /// </summary>
        public string Dzial { get; set; }
        /// <summary>
        /// Dotyczy oddziału klienta lub *
        /// </summary>
        public string Oddzial { get; set; }
        /// <summary>
        /// Oddział ID
        /// </summary>
        public int? OddzialId { get; set; }
        /// <summary>
        /// Udział w ogólnych przewozach w %
        /// </summary>
        public double? Udzial { get; set; }
        /// <summary>
        /// Okres
        /// </summary>
        public string Okres { get; set; }
    }
}
