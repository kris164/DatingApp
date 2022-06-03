using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Opłaty dodatkowe MBL
    /// </summary>
    public partial class DaneMblKoszty
    {
        public int IdDaneMblKoszty { get; set; }
        public int DaneMblId { get; set; }
        public int? Lp { get; set; }
        public string ContainersNumbers { get; set; }
        public string Seals { get; set; }
        public double? NoOfPkgs { get; set; }
        public string PackageType { get; set; }
        public string DescriptionOfGoods { get; set; }
        public double? CargoNetWeight { get; set; }
        public double? GrossWeight { get; set; }
        public string Measurement { get; set; }
    }
}
