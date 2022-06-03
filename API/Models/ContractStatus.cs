using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ContractStatus
    {
        public int ContractStatusId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Color { get; set; }
    }
}
