using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class CzynnosciPrzegPoz
    {
        public int IdCzynnosciPrzegPoz { get; set; }
        public int? CzynnosciId { get; set; }
        public int? Lp { get; set; }
        public int? WGrupyPrzegladPozId { get; set; }
        public string WGrupyPrzeglad { get; set; }
        public int? PrzegladPozId { get; set; }
        public string PrzegladPoz { get; set; }
    }
}
