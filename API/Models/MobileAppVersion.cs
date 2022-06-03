using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MobileAppVersion
    {
        public int MobileAppVersionId { get; set; }
        public string Name { get; set; }
        public int? MobileAppListId { get; set; }
    }
}
