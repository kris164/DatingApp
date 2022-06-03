using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaborZawory
    {
        public int IdTaborZawory { get; set; }
        public int? TaborId { get; set; }
        public string Producent { get; set; }
        public string Sterowanie { get; set; }
        public string Rodzaj { get; set; }
        public double? Srednica { get; set; }
        public string NrId { get; set; }
    }
}
