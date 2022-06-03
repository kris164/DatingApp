using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpZleceniaZbPoz
    {
        public int IdTmpZleceniaZbPoz { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public int? ZlecenieId { get; set; }
    }
}
