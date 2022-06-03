using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik wymagań taboru dla kontrahenta
    /// </summary>
    public partial class KontrahWymTaboru
    {
        public int IdKontrahWymTaboru { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int KontrahId { get; set; }
        /// <summary>
        /// Opis wymagań taboru
        /// </summary>
        public string WymTaboru { get; set; }
    }
}
