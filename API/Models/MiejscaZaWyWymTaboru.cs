using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Wymagania taboru dla POI-a (detal do MIEJSCA_ZA_ROZLADUNKU)
    /// </summary>
    public partial class MiejscaZaWyWymTaboru
    {
        public int IdMiejscaZaWyWymTaboru { get; set; }
        /// <summary>
        /// Relacja do POI-a - tab.: MIEJSCA_ZA_ROZLADUNKU
        /// </summary>
        public int? MiejscaZaRozladunkuId { get; set; }
        /// <summary>
        /// Nazwa wymaganego osprzętu
        /// </summary>
        public string Nazwa { get; set; }
        /// <summary>
        /// Opis
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Ilość
        /// </summary>
        public int? Ilosc { get; set; }
        /// <summary>
        /// WYM.WYP, TYP.ZAB, SP.LAD
        /// </summary>
        public string Typ { get; set; }
        public int? Zamiennik { get; set; }
    }
}
