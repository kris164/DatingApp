using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Prawa użytkowników do autoryzacji dodatkowych
    /// </summary>
    public partial class AutoryzacjePrawa
    {
        public int IdAutoryzacjePrawa { get; set; }
        /// <summary>
        /// Kod źródła wykonania
        /// </summary>
        public string SourceId { get; set; }
        /// <summary>
        /// Opis zdarzenia
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Kto może autoryzować
        /// </summary>
        public string KtoMoze { get; set; }
        /// <summary>
        /// Kod CRC do weryfikacji poprawnosci wpisu
        /// </summary>
        public string Crc { get; set; }
        /// <summary>
        /// Flaga, czy bez interakcji gdy uprawniony 
        /// </summary>
        public int? BezPotw { get; set; }
    }
}
