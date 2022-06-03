using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RodzOperKa
    {
        public int IdRodzOperKas { get; set; }
        public string Kod { get; set; }
        public string Opis { get; set; }
        public string Konto { get; set; }
        public string Lista { get; set; }
        public int? Kasa { get; set; }
        public int? Bank { get; set; }
        public int? KursOpis { get; set; }
        public int? Zaliczka { get; set; }
        public int? Cod { get; set; }
        public int? ZasilOdpr { get; set; }
        public string DodOpisNaWydr { get; set; }
    }
}
