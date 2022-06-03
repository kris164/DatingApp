using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WZleceniaTaborTerm
    {
        public int IdWZleceniaTaborTerm { get; set; }
        public int? WZlecenieId { get; set; }
        public int? TaborTerminId { get; set; }
        public string CzynnoscId { get; set; }
        public string Czynnosc { get; set; }
        public int? Wykonano { get; set; }
        public int? Licznik { get; set; }
        public DateTime? Data { get; set; }
        public int? WZleceniaOfertyId { get; set; }
        public string Uwagi { get; set; }
    }
}
