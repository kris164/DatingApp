using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaborWyposazenie1
    {
        public int? SolverTaskId { get; set; }
        public int? SessionId { get; set; }
        public int? IdTaboru { get; set; }
        public string Typ { get; set; }
        public string Nazwa { get; set; }
        public int? Ilosc { get; set; }
    }
}
