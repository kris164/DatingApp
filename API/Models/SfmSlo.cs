using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// listy słownikowe - detal (SFM_SLO_Def.Kod &lt;=&gt; SFM_SLO.Slownik)
    /// </summary>
    public partial class SfmSlo
    {
        public int IdSfmSlo { get; set; }
        /// <summary>
        /// kod słownika
        /// </summary>
        public string Slownik { get; set; }
        /// <summary>
        /// kod słownika - wyróżnik dodatkowy
        /// </summary>
        public string Wyroznik { get; set; }
        /// <summary>
        /// kod elementu słownika
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// opis elementu słownika
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// parametry dodatkowe
        /// </summary>
        public string Parametry { get; set; }
    }
}
