using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaborTeczkaSzablonPoz
    {
        public int IdTaborTeczkaSzablonPoz { get; set; }
        public int? TaborTeczkaSzablonId { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public int? Ilosc { get; set; }
    }
}
