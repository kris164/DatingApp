using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmTrasa
    {
        public int IdSfmTrasa { get; set; }
        public int? IdSfmTabor { get; set; }
        public string NrInwent { get; set; }
        public string NrRej { get; set; }
        public int? IdPw { get; set; }
        public int? IdZlecenia { get; set; }
        public string Nrzlec { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Dataplanstart { get; set; }
        public DateTime? Dataplanstop { get; set; }
        public DateTime? Datastart { get; set; }
        public DateTime? Datastop { get; set; }
        public int? Problemy { get; set; }
        public int? Status { get; set; }
        public string Opis { get; set; }
        public string Uwagi { get; set; }
    }
}
