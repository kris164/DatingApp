using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MapOptiRouteSave
    {
        public int Idx { get; set; }
        public DateTime? DtCreate { get; set; }
        public int? SessionId { get; set; }
        public string Step { get; set; }
        public string Xml { get; set; }
    }
}
