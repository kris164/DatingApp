using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WZleceniaPrzegPoz
    {
        public int IdWZleceniaPrzegPoz { get; set; }
        public int? WZlecenieId { get; set; }
        public int? Lp { get; set; }
        public int? PrzegladPozId { get; set; }
        public string PrzegladPoz { get; set; }
        public int? Wykonano { get; set; }
        public int? WGrupyPrzegladPozId { get; set; }
        public string WGrupyPrzeglad { get; set; }
        public int? WZleceniaOfertyId { get; set; }
    }
}
