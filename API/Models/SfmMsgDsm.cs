using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmMsgDsm
    {
        public int IdSfmMsg { get; set; }
        public string TerminalIp { get; set; }
        public int? TerminalPort { get; set; }
        public string Macro { get; set; }
        public int? Watek { get; set; }
        public string Md5 { get; set; }
    }
}
