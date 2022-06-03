using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class AnkietyPyt
    {
        public int IdAnkietyPyt { get; set; }
        public int ObjId { get; set; }
        public int Lp { get; set; }
        public int Aktywne { get; set; }
        public string Pytanie { get; set; }
        public string TypOdp { get; set; }
        public string ZrodloListy { get; set; }
        public string OdpDomyslna { get; set; }
        public int? OdpWymagana { get; set; }
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
    }
}
