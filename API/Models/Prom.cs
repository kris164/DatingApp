using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Prom
    {
        public int IdProm { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public int? ArmatorId { get; set; }
        public string Armator { get; set; }
    }
}
