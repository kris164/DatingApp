using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ZleceniaWymTaboru
    {
        public int IdZleceniaWymTaboru { get; set; }
        public int? ZlecenieId { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public int? Ilosc { get; set; }
        /// <summary>
        /// WYM.WYP, TYP.ZAB, SP.LAD
        /// </summary>
        public string Typ { get; set; }
        public int? Zamiennik { get; set; }
        public int? NieBlokuj { get; set; }
    }
}
