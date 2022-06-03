using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class InventoryStatus
    {
        public int InventoryStatusId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int? Color { get; set; }
    }
}
