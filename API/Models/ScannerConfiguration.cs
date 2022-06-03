using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ScannerConfiguration
    {
        public int ScannerConfigurationId { get; set; }
        public int VariableId { get; set; }
        public string Name { get; set; }
        public string Hint { get; set; }
        public byte[] Value { get; set; }
        public byte[] DefaultValue { get; set; }
    }
}
