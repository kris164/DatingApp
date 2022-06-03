using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmMsgAttach
    {
        public int IdSfmMsgAttach { get; set; }
        public DateTime? Dt { get; set; }
        public int? IsSent { get; set; }
        public int? IdSfmMsg { get; set; }
        public Guid? IdGroup { get; set; }
        public string FileName { get; set; }
        public byte[] FileData { get; set; }

        public virtual SfmMsg IdSfmMsgNavigation { get; set; }
    }
}
