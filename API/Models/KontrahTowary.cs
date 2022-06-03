using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class KontrahTowary
    {
        public int IdKontrahTowary { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int KontrahId { get; set; }
        /// <summary>
        /// Relacja do towaru - tab: OPISY_TOWAROW
        /// </summary>
        public int OpisyTowaruId { get; set; }
        public string Symbol { get; set; }
        public string Opis { get; set; }
    }
}
