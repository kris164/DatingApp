using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WynagrodzeniaPoz
    {
        public int IdWynagrodzeniaPoz { get; set; }
        public int? IdKierowcy { get; set; }
        public DateTime? DataOd { get; set; }
        public DateTime? DataDo { get; set; }
        public double? Kwota { get; set; }
        public int? Typ { get; set; }
        public double? Etat { get; set; }
        public int? LimitDoNadgodzin { get; set; }
        public double? RyczaltNocki { get; set; }
        public double? RyczaltDyzury { get; set; }
        public double? RyczaltNadgodziny { get; set; }
        public double? RyczaltDyzur { get; set; }
    }
}
