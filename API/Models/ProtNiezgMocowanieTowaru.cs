using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ProtNiezgMocowanieTowaru
    {
        public int IdProtNiezgMocowanieTowaru { get; set; }
        public int? ProtNiezgId { get; set; }
        public int? ProtNiezgMocTowId { get; set; }
    }
}
