using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class OpisyTowarowWymTaboru
    {
        public int IdOpisyTowarowWymTaboru { get; set; }
        public int? OpisyTowarowId { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public int? Ilosc { get; set; }
        /// <summary>
        /// WYM.WYP, TYP.ZAB, SP.LAD
        /// </summary>
        public string Typ { get; set; }
        public int? Zamiennik { get; set; }
    }
}
