using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TypSzkodyZdarzenium
    {
        public int IdTypSzkodyZdarzenia { get; set; }
        public int? Lp { get; set; }
        public string Opis { get; set; }
        public string Szablon { get; set; }
        public int? Systemowy { get; set; }
    }
}
