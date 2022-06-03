using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Typy reprezentantów
    /// </summary>
    public partial class KontrahTypReprez
    {
        public int IdKontrahTypReprez { get; set; }
        /// <summary>
        /// Typ opiekuna OH, OB
        /// </summary>
        public string Kind { get; set; }
        /// <summary>
        /// Nazwa typu reprezentanta
        /// </summary>
        public string Nazwa { get; set; }
    }
}
