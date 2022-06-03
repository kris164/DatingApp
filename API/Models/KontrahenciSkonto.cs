using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Definicje SKONTA dla kontrahentów
    /// </summary>
    public partial class KontrahenciSkonto
    {
        public int IdKontrahenciSkonto { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int KontrahId { get; set; }
        /// <summary>
        /// Czy skonto domyślne
        /// </summary>
        public int Def { get; set; }
        /// <summary>
        /// Termin płatności
        /// </summary>
        public int Termin { get; set; }
        /// <summary>
        /// % wartosć SKONTA
        /// </summary>
        public double Skonto { get; set; }
    }
}
