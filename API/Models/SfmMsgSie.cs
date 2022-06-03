using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmMsgSie
    {
        public int IdSfmMsg { get; set; }
        /// <summary>
        /// ID systemu w bazie SFM
        /// </summary>
        public int? IdSfmSystem { get; set; }
        public int? DevId { get; set; }
        public string Msgtype { get; set; }
        public int? Msgid { get; set; }
        public DateTime? Dt { get; set; }
        public long? Recid { get; set; }
        public short? Msgkind { get; set; }
        public DateTime? DtExpiry { get; set; }
        public string Jobnumber { get; set; }
        public DateTime? DtJobstart { get; set; }
        public short? Lateststatus { get; set; }
        public DateTime? DtLateststat { get; set; }
        public short? Urgent { get; set; }
        public string Joblocidlist { get; set; }
    }
}
