using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmMsgQua
    {
        public int IdSfmMsg { get; set; }
        public string Forwardgmh { get; set; }
        public string Gmh { get; set; }
        public string NoMsg { get; set; }
        public DateTime? TimeMsg { get; set; }
        public DateTime? TimeNmc { get; set; }
        public string Tripstatus { get; set; }
        public string Mctfirmwarever { get; set; }
        public string Binarychannel { get; set; }
    }
}
