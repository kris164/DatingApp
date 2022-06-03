using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MobileDriverPermission
    {
        public int MobileDriverPermissionId { get; set; }
        public string Name { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
