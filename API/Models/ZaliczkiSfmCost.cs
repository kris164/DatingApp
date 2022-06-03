using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ZaliczkiSfmCost
    {
        public int IdZaliczkiSfmCosts { get; set; }
        public int? ZaliczkiId { get; set; }
        public int? SfmCostsId { get; set; }
        public double? Kwota { get; set; }
    }
}
