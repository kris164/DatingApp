using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Segmenty działalności
    /// </summary>
    public partial class KontrahSegment
    {
        public int IdKontrahSegment { get; set; }
        public int? KontrahId { get; set; }
        public int? DictionaryValuesId { get; set; }
        public double? ProcentUdzialu { get; set; }
    }
}
