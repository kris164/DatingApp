using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class IncotermsPoz
    {
        public int IdIncotermsPoz { get; set; }
        public int? IncotermsId { get; set; }
        public int? OpisId { get; set; }
        public string Opis { get; set; }
        public string Kierunek { get; set; }
        public string Strona { get; set; }
        public string Typ { get; set; }
        public double? Kwota { get; set; }
        public string Waluta { get; set; }
    }
}
