using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmMsgRef
    {
        public int IdSfmMsgRef { get; set; }
        public int IdSfmMsg { get; set; }
        public int? IdObj { get; set; }
        public int? IdRec { get; set; }

        public virtual SfmMsg IdSfmMsgNavigation { get; set; }
    }
}
