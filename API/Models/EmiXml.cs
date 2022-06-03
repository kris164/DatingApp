using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class EmiXml
    {
        public int IdEmiXml { get; set; }
        public string Direction { get; set; }
        public string Type { get; set; }
        public DateTime Dt { get; set; }
        public string Xml { get; set; }
    }
}
