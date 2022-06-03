using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ListFilter
    {
        public int ListFilterId { get; set; }
        public string Name { get; set; }
        public int Active { get; set; }
        public int ToolId { get; set; }
        public int? ListLayoutTypeId { get; set; }
        public string Filter { get; set; }
        public int FilterOrder { get; set; }
    }
}
