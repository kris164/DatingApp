using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaborTerminSzablonPoz
    {
        public int IdTaborTerminSzablonPoz { get; set; }
        public int? TaborTerminSzablonId { get; set; }
        public string CzynnoscId { get; set; }
        public string Czynnosc { get; set; }
        public string Wskaznik { get; set; }
        public int? Interwal { get; set; }
        public string Uwagi { get; set; }
        public int? Weryfikacja { get; set; }
    }
}
