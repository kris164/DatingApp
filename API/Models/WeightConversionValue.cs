using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WeightConversionValue
    {
        public int IdWeightConversionValues { get; set; }
        public int WeightConversionId { get; set; }
        public double FromValue { get; set; }
        public string FromUnit { get; set; }
        public double ToValue { get; set; }
        public string ToUnit { get; set; }
        public double? TransportUnits { get; set; }
    }
}
