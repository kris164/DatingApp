using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Wersja
    {
        public int IdWersja { get; set; }
        public int? MarkaId { get; set; }
        public int? ModelId { get; set; }
        public string Nazwa { get; set; }
        public string ProdOd { get; set; }
        public string ProdDo { get; set; }
        public double? Poj { get; set; }
        public double? MocKm { get; set; }
        public double? MocKw { get; set; }
        public string Wyposazenie { get; set; }
    }
}
