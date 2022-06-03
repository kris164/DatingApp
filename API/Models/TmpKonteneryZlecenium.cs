using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpKonteneryZlecenium
    {
        public int IdTmpKonteneryZlecenia { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        /// <summary>
        /// Unikalny identyfikator polisy
        /// </summary>
        public int? IdKonteneryZlecenia { get; set; }
        public int? KonteneryId { get; set; }
        public string ZleceniaTyp { get; set; }
        public int? ZleceniaId { get; set; }
        public int? Lp { get; set; }
    }
}
