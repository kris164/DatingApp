using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik wyposażenia pojazdów
    /// </summary>
    public partial class WypTaboru
    {
        public int IdWypTaboru { get; set; }
        /// <summary>
        /// Lp
        /// </summary>
        public int? Lp { get; set; }
        /// <summary>
        /// Opis
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Flaga, czy element służy do planowania
        /// </summary>
        public int? DoPlanowania { get; set; }
        /// <summary>
        /// Flaga, czy element służy do rozliczenia
        /// </summary>
        public int? DoRozliczenia { get; set; }
        /// <summary>
        /// WYM.WYP, TYP.ZAB, SP.LAD
        /// </summary>
        public string Typ { get; set; }
        public int? DrobnWerP { get; set; }
        public int? DrobnWerL { get; set; }
        public int? DrobnWerD { get; set; }
        public int? Www { get; set; }
        public string Symbol { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
        public int? Visible { get; set; }
    }
}
