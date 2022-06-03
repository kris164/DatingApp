using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpListyLiniowePromy
    {
        public int IdTmpListyLiniowePromy { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public int? ListyLinioweId { get; set; }
        public int? PromyId { get; set; }
    }
}
