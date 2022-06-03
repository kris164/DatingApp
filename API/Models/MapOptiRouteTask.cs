using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MapOptiRouteTask
    {
        public int Idx { get; set; }
        public int? SessionId { get; set; }
        public string GroupId { get; set; }
        public int? TaskId { get; set; }
        public int? Lp { get; set; }
        public int? DistTotal { get; set; }
        public int? DistRoute { get; set; }
        public int? DistFerry { get; set; }
        public int? TimeTotal { get; set; }
        public int? TimeRoute { get; set; }
        public int? TimeFerry { get; set; }
        public string Step { get; set; }
        public string Xml { get; set; }
    }
}
