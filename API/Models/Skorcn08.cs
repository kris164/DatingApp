using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Skorcn08
    {
        public int IdSkorcn08 { get; set; }
        public string Cn { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public string Pkwiu { get; set; }
        public double? Vat { get; set; }
    }
}
