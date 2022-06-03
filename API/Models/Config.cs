using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Config
    {
        public int ConfigId { get; set; }
        public int VariableId { get; set; }
        public string Name { get; set; }
        public byte[] Value { get; set; }
    }
}
