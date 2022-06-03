using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ApplicationProfile
    {
        public int ApplicationProfileId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
