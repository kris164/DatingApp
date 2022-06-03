using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpSelRec
    {
        public int IdTmpSelRec { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        /// <summary>
        /// Relacja do OBJECT - typ obiektu
        /// </summary>
        public int? ObjectId { get; set; }
        /// <summary>
        /// ID zaznaczonego rekordu
        /// </summary>
        public int? RecId { get; set; }
    }
}
