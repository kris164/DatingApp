using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Adresy
    {
        public int IdAdresy { get; set; }
        public string Rodzaj { get; set; }
        public string Nazwa { get; set; }
        public int? NrOd { get; set; }
        public int? NrDo { get; set; }
        public string Kod { get; set; }
        public string Miasto { get; set; }
        public string Gmina { get; set; }
        public string Strefa { get; set; }
        public string SortKod { get; set; }
    }
}
