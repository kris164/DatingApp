using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MapaUtrudnienia2
    {
        public int IdMapaUtrudnienia2 { get; set; }
        public string Nazwa { get; set; }
        public int? Aktywne { get; set; }
        public int? Typ { get; set; }
    }
}
