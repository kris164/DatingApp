using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpPrzesylkiWymTaboru
    {
        public int IdTmpPrzesylkiWymTaboru { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public string Typ { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public int? Ilosc { get; set; }
        public int? Zamiennik { get; set; }
        public int? NieBlokuj { get; set; }
    }
}
