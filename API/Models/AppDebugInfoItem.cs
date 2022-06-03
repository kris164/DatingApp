using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class AppDebugInfoItem
    {
        public int IdAppDebugInfoItem { get; set; }
        public int? AppDebugInfoId { get; set; }
        public int? AppDebugInfoObjectId { get; set; }
        public DateTime? Dt { get; set; }
        public long? BaseTc { get; set; }
        public long? LastTc { get; set; }
        public long? LastTcdb { get; set; }
        public long? CurrentTc { get; set; }
        public long? Btc { get; set; }
        public long? Ctc { get; set; }
        public long? Ctcdb { get; set; }
        public int? Level { get; set; }
        public string Info { get; set; }
    }
}
