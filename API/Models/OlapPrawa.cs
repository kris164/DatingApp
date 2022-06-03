using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class OlapPrawa
    {
        public int IdOlapPrawa { get; set; }
        public int? OlapDefinicjeId { get; set; }
        public int? UserId { get; set; }
        public int? GrupaId { get; set; }
        public int? Edycja { get; set; }
        public int? Widok { get; set; }
    }
}
