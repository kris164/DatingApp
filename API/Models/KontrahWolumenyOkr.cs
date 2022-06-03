using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Wolumenty okresowe
    /// </summary>
    public partial class KontrahWolumenyOkr
    {
        public int IdKontrahWolumenyOkr { get; set; }
        public int? KontrahId { get; set; }
        public int? Aktywny { get; set; }
        public int? Rodzaj { get; set; }
        public int? Typ { get; set; }
    }
}
