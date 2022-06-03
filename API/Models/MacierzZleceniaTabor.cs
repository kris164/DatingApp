using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MacierzZleceniaTabor
    {
        public int Id { get; set; }
        public int? SolverTaskId { get; set; }
        public int? SessionId { get; set; }
        public int? IdZlecenia { get; set; }
        public int? IdTaboru { get; set; }
        public int? IdKierowcy { get; set; }
        public int? TaborWarunkowo { get; set; }
    }
}
