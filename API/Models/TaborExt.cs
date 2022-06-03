using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaborExt
    {
        public int IdTaboru { get; set; }
        public string OstAlarm { get; set; }
        public string AktMiastoStart { get; set; }
        public int? AktLicznikStart { get; set; }
        public string AktMiastoStop { get; set; }
        public int? AktLicznikStop { get; set; }
        public string AktPozycja { get; set; }
        public int? AktNaczepaId { get; set; }
        public string AktNaczepa { get; set; }
        public int? AktKierowcaId { get; set; }
        public string AktKierowca { get; set; }
        public string AktKierowcaTel { get; set; }
        public int? AktywneSledzenie { get; set; }
    }
}
