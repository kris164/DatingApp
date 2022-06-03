using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class FtlCalc
    {
        public int IdFtlCalc { get; set; }
        public DateTime? CalcDt { get; set; }
        public int? UserId { get; set; }
        public int? TruckId { get; set; }
        public int? TrailerId { get; set; }
        public int? Driver1Id { get; set; }
        public int? Driver2Id { get; set; }
        public int? EmptyKm { get; set; }
        public int? LoadingKm { get; set; }
        public int? FullKm { get; set; }
        public string CalcResult { get; set; }
        public int? State { get; set; }
    }
}
