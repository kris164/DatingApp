using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmMsgVdf
    {
        public int IdSfmMsg { get; set; }
        /// <summary>
        /// ID systemu w bazie SFM
        /// </summary>
        public int? IdSfmSystem { get; set; }
        public int? UsrId { get; set; }
        public int? DevId { get; set; }
        public int? MsgId { get; set; }
        public int? OrderId { get; set; }
        public int? TaskStat { get; set; }
    }
}
