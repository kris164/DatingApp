using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class OptiEtaSimulation
    {
        public int Idx { get; set; }
        public DateTime? DtCreate { get; set; }
        public DateTime? DtStart { get; set; }
        public int? SessionId { get; set; }
        public string Step { get; set; }
        public string GroupId { get; set; }
        public int? DriverId1 { get; set; }
        public int? DriverId2 { get; set; }
        public string Error { get; set; }
        public string Simulation { get; set; }
    }
}
