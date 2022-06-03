using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PrzesylkiWymTaboru
    {
        public int IdPrzesylkiWymTaboru { get; set; }
        public int? PrzesylkiId { get; set; }
        /// <summary>
        /// WYM.WYP, TYP.ZAB, SP.LAD
        /// </summary>
        public string Typ { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public int? Ilosc { get; set; }
        public int? Zamiennik { get; set; }
        public int? NieBlokuj { get; set; }
    }
}
