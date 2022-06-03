using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class OfertyDrobnTowary
    {
        public int IdOfertyDrobnTowary { get; set; }
        public int? OfertyDrobnUslugiId { get; set; }
        public string Nazwa { get; set; }
        public string Adr { get; set; }
        public double? Ilosc { get; set; }
        public double? Waga { get; set; }
        public double? Wys { get; set; }
        public double? Szer { get; set; }
        public double? Dlug { get; set; }
        public double? Kub { get; set; }
        public double? Ldm { get; set; }
    }
}
