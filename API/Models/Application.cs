using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Application
    {
        public int ApplicationId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int? CurrentApplicationVersionId { get; set; }
    }
}
