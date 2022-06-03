using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Powiazania kontrahentów pomiędzy sobą (JPK_VAT
    /// </summary>
    public partial class KontrahenciPowiazani
    {
        public int IdKontrahenciPowiazani { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int Kontrah1Id { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int Kontrah2Id { get; set; }
    }
}
