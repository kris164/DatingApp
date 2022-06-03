using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class DataProcessor
    {
        public int IdDataProcessor { get; set; }
        public int? DataKindId { get; set; }
        public int? DataProcessorModuleId { get; set; }
        public int? Enabled { get; set; }
        public DateTime? LastRun { get; set; }
        public DateTime? LastStop { get; set; }
        public string NextRunInterval { get; set; }
        public int? NextRunIncrement { get; set; }
        public DateTime? NextRun { get; set; }
        public string Config { get; set; }
    }
}
