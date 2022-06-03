using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RequestPermissionGroup
    {
        public int RequestPermissionGroupId { get; set; }
        public int DictionaryId { get; set; }
        public int TextId { get; set; }
        public int? Active { get; set; }
        public int? GroupOrder { get; set; }
    }
}
