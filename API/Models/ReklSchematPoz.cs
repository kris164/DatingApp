using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ReklSchematPoz
    {
        public int IdReklSchematPoz { get; set; }
        public int? ReklSchematId { get; set; }
        public int? Lp { get; set; }
        public string Akcja { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public string Uwagi { get; set; }
        public int? Dzien { get; set; }
        public int? PracownikId { get; set; }
        public string Pracownik { get; set; }
    }
}
