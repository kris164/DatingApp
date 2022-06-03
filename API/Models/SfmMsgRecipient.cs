using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmMsgRecipient
    {
        public int IdSfmMsgRecipients { get; set; }
        public int IdSfmMsg { get; set; }
        public string Address { get; set; }
        public int? AddressMode { get; set; }

        public virtual SfmMsg IdSfmMsgNavigation { get; set; }
    }
}
