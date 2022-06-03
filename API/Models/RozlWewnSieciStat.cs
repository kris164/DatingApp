using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RozlWewnSieciStat
    {
        public int IdRozlWewnSieciStat { get; set; }
        public int? RozlWewnSieciId { get; set; }
        public string StatusKod { get; set; }
        public string StatusOpis { get; set; }
    }
}
