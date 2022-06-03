using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class EdiStatusy2insert
    {
        public int IdEdiStatusy2insert { get; set; }
        public int IdObj { get; set; }
        public int IdRec { get; set; }
        public string Source { get; set; }
        public string Status { get; set; }
        public string Lokalizacja { get; set; }
        public string Info { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Czas { get; set; }
        public DateTime? InsertDt { get; set; }
        public int Done { get; set; }
        public DateTime? DoneDt { get; set; }
        public string InsertWho { get; set; }
    }
}
