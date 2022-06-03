using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpZleceniaPromy
    {
        public int IdTmpZleceniaPromy { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public int? ZleceniaId { get; set; }
        public int? PromyId { get; set; }
    }
}
