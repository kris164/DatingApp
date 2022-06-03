using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class BilansOpakLok
    {
        public int IdBilansOpakLok { get; set; }
        public string Stan { get; set; }
        public DateTime Data { get; set; }
        public DateTime Godz { get; set; }
        public DateTime? DataZamkniecia { get; set; }
        public DateTime? GodzZamkniecia { get; set; }
        public string Dzial { get; set; }
        public int? Ftl { get; set; }
        public DateTime? DataDo { get; set; }
        public DateTime? DataOd { get; set; }
    }
}
