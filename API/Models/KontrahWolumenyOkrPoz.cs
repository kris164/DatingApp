using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Wolumenty okresowe - pozycje
    /// </summary>
    public partial class KontrahWolumenyOkrPoz
    {
        public int IdKontrahWolumenyOkrPoz { get; set; }
        public int? KontrahWolumenyOkrId { get; set; }
        public int? Okres { get; set; }
        public double? Wartosc { get; set; }
    }
}
