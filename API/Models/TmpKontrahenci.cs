using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpKontrahenci
    {
        public int IdTmpKontrahenci { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        /// <summary>
        /// Typ kontrahenta - mapa bitowa
        /// </summary>
        public string TypKontr { get; set; }
        /// <summary>
        /// Symbol kontrahenta
        /// </summary>
        public string Symbol { get; set; }
        /// <summary>
        /// Kraj
        /// </summary>
        public string Kraj { get; set; }
    }
}
