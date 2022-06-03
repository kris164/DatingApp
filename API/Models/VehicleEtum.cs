using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class VehicleEtum
    {
        public int IdVehicleEta { get; set; }
        public int? VehicleId { get; set; }
        public int? Mode { get; set; }
        public string Input { get; set; }
        public string Output { get; set; }
        public DateTime? DtNextRun { get; set; }
        public DateTime DtCreate { get; set; }
        public DateTime DtModify { get; set; }
    }
}
