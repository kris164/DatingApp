using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class FtlCalcCostItem
    {
        public int IdFtlCalcCostItems { get; set; }
        public int? IdFtlCalc { get; set; }
        public int? IdItemDict { get; set; }
        public double? Quantity { get; set; }
        public double? Price { get; set; }
        public double? Value { get; set; }
        public string Currency { get; set; }
        public int? FromMap { get; set; }
    }
}
