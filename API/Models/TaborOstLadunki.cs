using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaborOstLadunki
    {
        public int IdTaborOstLadunki { get; set; }
        public int? TaborId { get; set; }
        public int? Komora { get; set; }
        public int? LadunekId { get; set; }
        public string Ladunek { get; set; }
        public string LadunekGrupa { get; set; }
        public DateTime? Data { get; set; }
        public string Zlecenie { get; set; }
    }
}
