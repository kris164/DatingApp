using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class KierowcyWyposSzablonPoz
    {
        public int IdKierowcyWyposSzablonPoz { get; set; }
        public int? KierowcyWyposSzablonId { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public int? Ilosc { get; set; }
        public double? Wartosc { get; set; }
        public string WartoscWal { get; set; }
    }
}
