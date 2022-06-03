using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ApplicationContext
    {
        public int ApplicationContextId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
