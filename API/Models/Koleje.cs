using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Koleje
    {
        public int IdKoleje { get; set; }
        public string Kod { get; set; }
        public string Opis { get; set; }
        public string Kraj { get; set; }
    }
}
