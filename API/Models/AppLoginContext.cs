using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class AppLoginContext
    {
        public int AppLoginContextId { get; set; }
        public int? Version { get; set; }
        public string Data { get; set; }
    }
}
