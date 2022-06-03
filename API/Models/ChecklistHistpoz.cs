using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ChecklistHistpoz
    {
        public int IdChecklistHistpoz { get; set; }
        public int? IdChecklistHist { get; set; }
        public int? IdChecklistPyt { get; set; }
        public int? Odpowiedz { get; set; }
        public int? Lp { get; set; }
    }
}
