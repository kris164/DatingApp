using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ChecklistPyt
    {
        public int IdChecklistPyt { get; set; }
        public string Tekst { get; set; }
        public short? Aktywne { get; set; }
    }
}
