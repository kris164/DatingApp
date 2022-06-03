using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ParameterType
    {
        public int ParameterTypeId { get; set; }
        public string Name { get; set; }
        public int? Order { get; set; }
        public int? Visible { get; set; }
    }
}
