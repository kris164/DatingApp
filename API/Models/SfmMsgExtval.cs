using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmMsgExtval
    {
        public int IdSfmMsg { get; set; }
        /// <summary>
        /// nazwa wartości dodatkowych
        /// </summary>
        public string Nazwa { get; set; }
        /// <summary>
        /// wartości dodatkowe
        /// </summary>
        public string Extval { get; set; }
        /// <summary>
        /// obiekt - id tablicy
        /// </summary>
        public int? IdObj { get; set; }
        /// <summary>
        /// id w obiekcie (patrz ID_OBJ)
        /// </summary>
        public int? IdRec { get; set; }
        /// <summary>
        /// id statusu (z tab. STATUSY) związanego z ID_REC
        /// </summary>
        public int? IdStatusy { get; set; }
    }
}
