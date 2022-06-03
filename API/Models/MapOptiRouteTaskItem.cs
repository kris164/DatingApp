using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MapOptiRouteTaskItem
    {
        public int Idx { get; set; }
        public int? SessionId { get; set; }
        public string GroupId { get; set; }
        public int? TaskId { get; set; }
        public int? Lp { get; set; }
        public int? Distance { get; set; }
        public int? Time { get; set; }
        public int? Ferry { get; set; }
        public string Type { get; set; }
        public string Step { get; set; }
    }
}
