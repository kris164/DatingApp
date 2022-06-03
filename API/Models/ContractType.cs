using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ContractType
    {
        public int ContractTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Visible { get; set; }
    }
}
