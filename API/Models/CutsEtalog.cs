using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class CutsEtalog
    {
        public int? SolverTaskId { get; set; }
        public int? SessionId { get; set; }
        public int? MacierzZleceniaTaborId { get; set; }
        public int? IdZlecenia { get; set; }
        public string NrZleceniaK { get; set; }
        public string NrZlecenia { get; set; }
        public int? IdTaboru { get; set; }
        public string NrRej { get; set; }
        public int? IdKierowcy { get; set; }
        public string Kierowca { get; set; }
        public int? Lp { get; set; }
        public string Typ { get; set; }
        public string Miejsce { get; set; }
        public DateTime? DataOd { get; set; }
        public DateTime? DataDo { get; set; }
        public DateTime? DataEta { get; set; }
        public string Eta { get; set; }
    }
}
