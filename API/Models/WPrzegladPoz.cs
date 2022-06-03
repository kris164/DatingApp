using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WPrzegladPoz
    {
        public int IdWPrzegladPoz { get; set; }
        public int? Lp { get; set; }
        public string Opis { get; set; }
        public int? Widoczny { get; set; }
    }
}
