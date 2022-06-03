using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TermPlatnKoszt
    {
        public int IdTermPlatnKoszt { get; set; }
        public int? DniOd { get; set; }
        public int? DniDo { get; set; }
        public int? Termin { get; set; }
    }
}
