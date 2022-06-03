using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Profile
    {
        public int ProfileId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Visible { get; set; }
    }
}
