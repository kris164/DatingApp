using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Ramki
    {
        public int IdRamki { get; set; }
        public int? IdKomunikaty { get; set; }
        public string TerminalIp { get; set; }
        public int? TerminalPort { get; set; }
        public string Typ { get; set; }
        public int? Rodzaj { get; set; }
        public DateTime? Dt { get; set; }
        public int Lp { get; set; }
        public string Tresc { get; set; }
        public int Wyslano { get; set; }
    }
}
