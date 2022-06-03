using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ProtNiezgSposobOpakowanium
    {
        public int IdProtNiezgSposobOpakowania { get; set; }
        public int? ProtNiezgId { get; set; }
        public int? ProtNiezgSposobOpakId { get; set; }
    }
}
