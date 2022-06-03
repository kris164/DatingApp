using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class AppSchemaGroup1
    {
        public int AppSchemaGroupId { get; set; }
        public string GroupName { get; set; }
        public string GroupDescription { get; set; }
        public string Prefix { get; set; }
        public int? System { get; set; }
        public int? Visible { get; set; }
    }
}
