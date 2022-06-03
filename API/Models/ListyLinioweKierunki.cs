using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ListyLinioweKierunki
    {
        public int IdListyLinioweKierunki { get; set; }
        public int? ListyLinioweId { get; set; }
        public string Lokalizacja { get; set; }
        public double? Waga { get; set; }
        public double? Obj { get; set; }
        public double? Mp { get; set; }
        public double? Ilosc { get; set; }
    }
}
