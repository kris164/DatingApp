using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class OpakowaniaLok
    {
        public int IdOpakowaniaLok { get; set; }
        public int? OpakowaniaId { get; set; }
        public string Lokalizacja { get; set; }
        public double? MagPrzyjeto { get; set; }
        public double? MagWydano { get; set; }
        public double? MagStan { get; set; }
    }
}
