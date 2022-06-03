using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Definicje praw do SID - Schemty Importu Danych
    /// </summary>
    public partial class SidPrawa
    {
        public int IdSidPrawa { get; set; }
        /// <summary>
        /// Relacja do SID
        /// </summary>
        public int? SidId { get; set; }
        /// <summary>
        /// Relacja do użytkownika
        /// </summary>
        public int? UzytkownikId { get; set; }
    }
}
