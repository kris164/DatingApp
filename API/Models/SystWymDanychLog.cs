using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SystWymDanychLog
    {
        public int IdSystWymDanychLog { get; set; }
        /// <summary>
        /// Relacja do systemów wymiany danych - tab: SYST_WYM_DANYCH
        /// </summary>
        public int? SystWymDanychId { get; set; }
        public DateTime? Dt { get; set; }
        public int? Typ { get; set; }
        public string Obiekt { get; set; }
        public string Opis { get; set; }
    }
}
