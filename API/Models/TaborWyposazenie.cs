using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaborWyposazenie
    {
        public int IdTaborWyposazenie { get; set; }
        public int TaborId { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public int? Ilosc { get; set; }
        public DateTime? DataWaznosci { get; set; }
        public int? DoPlanowania { get; set; }
        public int? DoRozliczenia { get; set; }
        public int? WMagWydaniaPozId { get; set; }
        public int? Arch { get; set; }
        public DateTime? DataArch { get; set; }
        public string Uwagi { get; set; }
        /// <summary>
        /// WYM.WYP, TYP.ZAB, SP.LAD
        /// </summary>
        public string Typ { get; set; }
        public int? WypTaboruId { get; set; }
    }
}
