using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class FtlCalcIncomeItem
    {
        public int IdFtlCalcIncomeItems { get; set; }
        public int? IdFtlCalc { get; set; }
        public int? IdItemDict { get; set; }
        public double? Quantity { get; set; }
        public double? Price { get; set; }
        public double? Value { get; set; }
        public string Currency { get; set; }
    }
}
