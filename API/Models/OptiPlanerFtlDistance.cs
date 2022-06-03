using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class OptiPlanerFtlDistance
    {
        public int IdOptiPlanerFtlDistance { get; set; }
        public int SessionId { get; set; }
        public int ObjId { get; set; }
        public int RecId { get; set; }
        public double? Distance { get; set; }
    }
}
