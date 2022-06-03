using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WynagrStaze
    {
        public int IdWynagrStaze { get; set; }
        public int? StazOd { get; set; }
        public int? StazDo { get; set; }
        public double? StawkaDod { get; set; }
        public double? StalaKwota { get; set; }
    }
}
