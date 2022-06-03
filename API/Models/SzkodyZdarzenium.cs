using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SzkodyZdarzenium
    {
        public int IdSzkodyZdarzenia { get; set; }
        public int? SzkodyId { get; set; }
        public string Szkody { get; set; }
        public string Tabor { get; set; }
        public int? TypId { get; set; }
        public string Typ { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Godz { get; set; }
        public string Opis { get; set; }
    }
}
