using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Wynagrodzenium
    {
        public int IdWynagrodzenia { get; set; }
        public int? IdKierowcy { get; set; }
        public DateTime? DataZatrudnienia { get; set; }
        public DateTime? DataZwolnienia { get; set; }
        public int? TrybPracy { get; set; }
    }
}
