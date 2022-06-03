using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class OlapGroup
    {
        public int OlapGroupId { get; set; }
        public string Name { get; set; }
        public int? OrdinalNumber { get; set; }
        public int? Visible { get; set; }
        public int? System { get; set; }
    }
}
