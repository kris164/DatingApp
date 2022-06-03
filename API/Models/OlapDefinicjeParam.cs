using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class OlapDefinicjeParam
    {
        public int IdOlapDefinicjeParams { get; set; }
        public int? OlapDefinicjeId { get; set; }
        public string Nazwa { get; set; }
        public string Etykieta { get; set; }
        public string Typ { get; set; }
        public string WartDomyslna { get; set; }
        public string ListaSql { get; set; }
        public int? Ukryty { get; set; }
    }
}
