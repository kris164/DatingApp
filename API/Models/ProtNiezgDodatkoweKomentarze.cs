using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ProtNiezgDodatkoweKomentarze
    {
        public int IdProtNiezgDodatkoweKomentarze { get; set; }
        public int? ProtNiezgId { get; set; }
        public int? ProtNiezgDodKomentId { get; set; }
    }
}
