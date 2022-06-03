using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ZleceniaOstLadunki
    {
        public int IdZleceniaOstLadunki { get; set; }
        public int? ZlecenieId { get; set; }
        public int? Typ { get; set; }
        public int? TaborId { get; set; }
        public int? Komora { get; set; }
        public int? LadunekId { get; set; }
        public string Grupa { get; set; }
        public DateTime? Data { get; set; }
    }
}
