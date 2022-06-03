using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// **** NIEUŻYWANA
    /// </summary>
    public partial class FakturyZlec
    {
        public int IdFakturyZlec { get; set; }
        public int? Typ { get; set; }
        public int? FakturaId { get; set; }
        public int? ZlecenieId { get; set; }
    }
}
