using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WynagrodzenieMin
    {
        public int IdWynagrodzenieMin { get; set; }
        public DateTime? DataOd { get; set; }
        public double? Kwota { get; set; }
        public double? ProcentZaNocne { get; set; }
        public double? ProcentZaDyzur { get; set; }
        public int? LimitNadgodzin { get; set; }
    }
}
