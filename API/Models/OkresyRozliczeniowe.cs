using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Okresy rozliczeniowe dla liczników
    /// </summary>
    public partial class OkresyRozliczeniowe
    {
        public int IdOkresyRozliczeniowe { get; set; }
        /// <summary>
        /// Relacja do licznika - tab: LICZNIKI
        /// </summary>
        public int? LicznikiId { get; set; }
        /// <summary>
        /// Rok
        /// </summary>
        public int? Rok { get; set; }
        /// <summary>
        /// Miesiąc
        /// </summary>
        public int? Miesiac { get; set; }
        /// <summary>
        /// Flaga, czy okres zamknięty
        /// </summary>
        public int? Zamkniety { get; set; }
    }
}
