using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaborOsie
    {
        public int IdTaborOsie { get; set; }
        public int? TaborId { get; set; }
        public int? NrOsi { get; set; }
        public string Typ { get; set; }
        public string Rodzaj { get; set; }
        public string PiastaNr { get; set; }
        public string PiastaTyp { get; set; }
        public string LozyskoNr { get; set; }
        public string LozyskoRozm { get; set; }
        public string UszczelniaczNr { get; set; }
        public string UszczelniaczRozm { get; set; }
        public DateTime? DataGwarancji { get; set; }
    }
}
