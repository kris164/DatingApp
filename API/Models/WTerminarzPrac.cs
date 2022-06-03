using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WTerminarzPrac
    {
        public int IdWTerminarzPrac { get; set; }
        public int? WTerminarzId { get; set; }
        public int? WZleceniePozId { get; set; }
        public int? WZlecenieId { get; set; }
        public int? WPracownicyId { get; set; }
        public string WPracownicy { get; set; }
    }
}
