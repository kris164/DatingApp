using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaborWyposSzablonPoz
    {
        public int IdTaborWyposSzablonPoz { get; set; }
        public int? TaborWyposSzablonId { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public int? Ilosc { get; set; }
        public int? DoPlanowania { get; set; }
        public int? DoRozliczenia { get; set; }
        /// <summary>
        /// WYM.WYP, TYP.ZAB, SP.LAD
        /// </summary>
        public string Typ { get; set; }
        public int? WypTaboruId { get; set; }
    }
}
