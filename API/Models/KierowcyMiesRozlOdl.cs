using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class KierowcyMiesRozlOdl
    {
        public int IdKierowcyMiesRozlOdl { get; set; }
        public int? KierowcyMiesRozlId { get; set; }
        public string Tytul { get; set; }
        public double? Kwota { get; set; }
    }
}
