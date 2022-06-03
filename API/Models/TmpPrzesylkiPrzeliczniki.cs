using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpPrzesylkiPrzeliczniki
    {
        public int IdTmpPrzesylkiPrzeliczniki { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public int? PrzesylkiId { get; set; }
        public int? WartoscZ { get; set; }
        public string JmZ { get; set; }
        public int? WartoscDo { get; set; }
        public string JmDo { get; set; }
        public double? Jt { get; set; }
    }
}
