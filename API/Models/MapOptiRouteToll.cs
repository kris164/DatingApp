using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MapOptiRouteToll
    {
        public int Idx { get; set; }
        public int? SessionId { get; set; }
        public string GroupId { get; set; }
        public int? Lp { get; set; }
        public string Type { get; set; }
        public string System { get; set; }
        public string Country { get; set; }
        public int? Lpp { get; set; }
        public double? Cost { get; set; }
        public string Currency { get; set; }
        public int? DaylightHrs { get; set; }
        public string PassType { get; set; }
        public int? PassNr { get; set; }
        public string Step { get; set; }
        public string Xml { get; set; }
    }
}
