using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TachoPunkty
    {
        public int IdTachoPunkty { get; set; }
        public int IdTacho { get; set; }
        public int? SladDrogi { get; set; }
        public int? PosX { get; set; }
        public int? PosY { get; set; }
        public int? Poziom { get; set; }
        public int? IdZdarzenia { get; set; }
    }
}
