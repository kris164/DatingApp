using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class DpsOptiRoutesGetTaskGroupsVehTask
    {
        public int Id { get; set; }
        public DateTime? InsertDt { get; set; }
        public int? SolverTaskId { get; set; }
        public int? SessionId { get; set; }
        public int? IdTaboru { get; set; }
        public int? IdZleceniaZaWy { get; set; }
        public int? Lp { get; set; }
        public decimal? Lat { get; set; }
        public decimal? Lon { get; set; }
        public DateTime? Dt { get; set; }
        public DateTime? DtMax { get; set; }
        public int? Duration { get; set; }
    }
}
