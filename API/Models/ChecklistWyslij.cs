using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ChecklistWyslij
    {
        public int IdChecklistWyslij { get; set; }
        public int? IdTabor { get; set; }
        public int? IdUzytk { get; set; }
        public string Uzytk { get; set; }
        public DateTime? DtWysylki { get; set; }
        public DateTime? DtZapis { get; set; }
        public short? Wyslano { get; set; }
        public string Errormsg { get; set; }
    }
}
