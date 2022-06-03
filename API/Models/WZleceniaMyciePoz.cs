using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WZleceniaMyciePoz
    {
        public int IdWZleceniaMyciePoz { get; set; }
        public int? WZlecenieId { get; set; }
        public int? Lp { get; set; }
        public int? WMyciePozId { get; set; }
        public string WMyciePoz { get; set; }
        public int? Wykonano { get; set; }
        public int? WZleceniaOfertyId { get; set; }
    }
}
