using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class LogService
    {
        public int IdLogService { get; set; }
        public double? Czasstart { get; set; }
        public double? Czasstop { get; set; }
        public int? IdUzytk { get; set; }
        public string IpStacji { get; set; }
        public string App { get; set; }
        public string Kod { get; set; }
        public string Klucz { get; set; }
        public string NazwaUzytk { get; set; }
        public string NazwaStacji { get; set; }
        public string Info { get; set; }
    }
}
