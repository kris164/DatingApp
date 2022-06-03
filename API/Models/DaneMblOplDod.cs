using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Opłaty dodatkowe MBL
    /// </summary>
    public partial class DaneMblOplDod
    {
        public int IdDaneMblOplDod { get; set; }
        public int DaneMblId { get; set; }
        public string Description { get; set; }
        public string Symbol { get; set; }
        public string Currency { get; set; }
        public string Paidtype { get; set; }
        public double? Wartosc { get; set; }
    }
}
