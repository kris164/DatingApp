using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ProtNiezgZdarzenium
    {
        public int IdProtNiezgZdarzenia { get; set; }
        public string Zdarzenie { get; set; }
        public string Opis { get; set; }
        public int? Aktywne { get; set; }
    }
}
