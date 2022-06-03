using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class KonteneryZlecenium
    {
        public int IdKonteneryZlecenia { get; set; }
        public int? KonteneryId { get; set; }
        public string ZleceniaTyp { get; set; }
        public int? ZleceniaId { get; set; }
        public int? Lp { get; set; }
    }
}
