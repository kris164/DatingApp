using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WeightConversion
    {
        public int IdWeightConversion { get; set; }
        public int Enabled { get; set; }
        public int System { get; set; }
        public int Group { get; set; }
        public string Name { get; set; }
        public string Loc { get; set; }
        public string Dep { get; set; }
        public int? ClientId { get; set; }
        public string Desc { get; set; }
        public int LogAsAddition { get; set; }
        public double? LogLengthThresholdMin { get; set; }
        public double? LogLengthThresholdMax { get; set; }
        public double? LogWeightThresholdMin { get; set; }
        public double? LogWeightThresholdMax { get; set; }
        public int LogThresholdOnlyAbove { get; set; }
    }
}
