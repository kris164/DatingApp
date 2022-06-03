using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpZleceniaRail
    {
        public int IdTmpZleceniaRail { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public int? FrmId { get; set; }
    }
}
