using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class HelpTable
    {
        public int? SolverTaskId { get; set; }
        public string AktLokalizacja { get; set; }
        public string AktDzial { get; set; }
        public int? AktUzytkId { get; set; }
        public string AktZrodlo { get; set; }
        public DateTime? DataOd { get; set; }
        public DateTime? DataDo { get; set; }
        public int? SessionId { get; set; }
        public DateTime? InsertDt { get; set; }
    }
}
