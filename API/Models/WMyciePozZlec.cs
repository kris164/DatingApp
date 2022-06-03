using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WMyciePozZlec
    {
        public int IdWMyciePozZlec { get; set; }
        public int? WMyciePozId { get; set; }
        public string Obj { get; set; }
        public int? ObjId { get; set; }
        public string Symbol { get; set; }
        public string Nazwa { get; set; }
        public string Jm { get; set; }
        public double? Ilosc { get; set; }
    }
}
