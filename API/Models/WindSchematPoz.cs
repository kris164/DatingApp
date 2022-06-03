using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WindSchematPoz
    {
        public int IdWindSchematPoz { get; set; }
        public int? WindSchematId { get; set; }
        public int? Lp { get; set; }
        public string Akcja { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public string Uwagi { get; set; }
        public int? Dzien { get; set; }
    }
}
