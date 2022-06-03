using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MobileVersionScript
    {
        public int MobileVersionScriptId { get; set; }
        public string ResourceName { get; set; }
        public int? MobileVersionId { get; set; }
        public int? Order { get; set; }
    }
}
