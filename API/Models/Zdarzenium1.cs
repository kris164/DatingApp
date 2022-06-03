using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Zdarzenium1
    {
        public int? SessionId { get; set; }
        public int? MacierzZleceniaTaborId { get; set; }
        public string Mode { get; set; }
        public string Driver1 { get; set; }
        public string Dt { get; set; }
        public string Time { get; set; }
        public string Info { get; set; }
    }
}
