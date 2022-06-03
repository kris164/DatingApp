using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmMsgCma
    {
        public int IdSfmMsg { get; set; }
        /// <summary>
        /// ID systemu w bazie SFM
        /// </summary>
        public int? IdSfmSystem { get; set; }
        public int? DevId { get; set; }
        public int? MsgId { get; set; }
        public int? StatId { get; set; }
        public int? DelStat { get; set; }
        public int? RefTask { get; set; }
        public int? TaskStat { get; set; }
        public int? OrderId { get; set; }
        public int? DriverId { get; set; }
    }
}
