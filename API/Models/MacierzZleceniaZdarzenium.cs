using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MacierzZleceniaZdarzenium
    {
        public int? MacierzZleceniaTaborId { get; set; }
        public int? SolverTaskId { get; set; }
        public int? SessionId { get; set; }
        public int? IdZlecenia { get; set; }
        public int? IdTaboru { get; set; }
        public int? IdKierowcy { get; set; }
        public int? IdZleceniaZaWy { get; set; }
        public int? Lp { get; set; }
        public int? DystansKm { get; set; }
        public int? CzasJazdyMin { get; set; }
        public int? CzasTrwaniaMin { get; set; }
        public DateTime? DtMin { get; set; }
        public DateTime? DtMax { get; set; }
        public DateTime? DtEta { get; set; }
        public string Eta { get; set; }
    }
}
