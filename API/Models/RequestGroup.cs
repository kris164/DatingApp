using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RequestGroup
    {
        public int RequestGroupId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
