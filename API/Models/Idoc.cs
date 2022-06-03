using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Idoc
    {
        public int IdIdoc { get; set; }
        public int? IdPrzesylki { get; set; }
        public string DeliverySap { get; set; }
        public short Status { get; set; }
        public DateTime? DtUtworz { get; set; }
        public short? Inout { get; set; }
        public string TypKomunikatu { get; set; }
        public string Nazwapliku { get; set; }
        public string Xml { get; set; }
    }
}
