using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ProtNiezgPost
    {
        public int IdProtNiezgPost { get; set; }
        public int? Lp { get; set; }
        public int? LpMobile { get; set; }
        public string Opis { get; set; }
        public int? Aktywne { get; set; }
        /// <summary>
        /// Wersja na mobile-u
        /// </summary>
        public int? MobileVersion { get; set; }
    }
}
