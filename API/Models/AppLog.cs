using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class AppLog
    {
        public int IdAppLog { get; set; }
        public string Operacja { get; set; }
        public int? OpExt { get; set; }
        public int? TypObjektu { get; set; }
        public int? IdObjektu { get; set; }
        public double? DataStart { get; set; }
        public double? DataStop { get; set; }
        public double? Czas { get; set; }
        public int? IdUzytk { get; set; }
        public string NazwaUzytk { get; set; }
        public string IpStacji { get; set; }
        public string NazwaStacji { get; set; }
        public string Info { get; set; }
    }
}
