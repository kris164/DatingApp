using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ZaliczkiFaktury
    {
        public int IdZaliczkiFaktury { get; set; }
        public int? ZaliczkiId { get; set; }
        public int? FakturyId { get; set; }
        public double? Kwota { get; set; }
    }
}
