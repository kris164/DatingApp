using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class AccessLevel
    {
        public int AccessLevelId { get; set; }
        public string Name { get; set; }
        public string Hint { get; set; }
    }
}
