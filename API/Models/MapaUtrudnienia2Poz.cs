using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MapaUtrudnienia2Poz
    {
        public int IdMapaUtrudnienia2Poz { get; set; }
        public int? MapaUtrudnieniaId { get; set; }
        public int? Lp { get; set; }
        public double? Lon { get; set; }
        public double? Lat { get; set; }
    }
}
