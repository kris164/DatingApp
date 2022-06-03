using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ZleceniaZaznaczoneWymaganium
    {
        public int? SolverTaskId { get; set; }
        public int? SessionId { get; set; }
        public int? IdZlecenia { get; set; }
        public string Typ { get; set; }
        public int? Ilosc { get; set; }
        public string Nazwa { get; set; }
        public int? Zamiennik { get; set; }
        public int? NieBlokuj { get; set; }
    }
}
