using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class OlapGrupy
    {
        public int IdOlapGrupy { get; set; }
        public int? Lp { get; set; }
        public string Grupa { get; set; }
        public int? Ikona { get; set; }
        public int? Widoczna { get; set; }
        public int? Systemowa { get; set; }
    }
}
