using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ChecklistTabor
    {
        public int IdChecklistTabor { get; set; }
        public int? IdChecklistPyt { get; set; }
        public int? IdTabor { get; set; }
        public int? Lp { get; set; }
    }
}
