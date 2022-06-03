using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpKontrahenciOpak
    {
        public int IdTmpKontrahenciOpak { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        /// <summary>
        /// Relacja do opakowania - tab: OPAKOWANIA
        /// </summary>
        public int OpakowaniaId { get; set; }
    }
}
