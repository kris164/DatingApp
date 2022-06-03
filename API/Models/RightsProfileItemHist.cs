using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RightsProfileItemHist
    {
        public int IdRightsProfileItemHist { get; set; }
        public int? RightsProfileHistId { get; set; }
        public string Class { get; set; }
        public int? TypeWb { get; set; }
        public string Mode { get; set; }
        public string Action { get; set; }
        public int? Disabled { get; set; }
        public int? Hidden { get; set; }

        public virtual RightsProfileHist RightsProfileHist { get; set; }
    }
}
