using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WGrupyPrzegladPoz
    {
        public int IdWGrupyPrzegladPoz { get; set; }
        public int? Lp { get; set; }
        public int? WGrupyPrzegladId { get; set; }
        public int? WPrzegladPozId { get; set; }
        public string WPrzegladPoz { get; set; }
    }
}
