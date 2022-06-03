using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmMsgSm
    {
        public int IdSfmMsg { get; set; }
        public string Telefon { get; set; }
        public string Phoneno { get; set; }
        public string Msgref { get; set; }
        public int? Stat { get; set; }
        public string Md5 { get; set; }
        public string Msgtxt { get; set; }
        /// <summary>
        /// ID systemu w bazie SFM
        /// </summary>
        public int? IdSfmSystem { get; set; }
        public long? RefId { get; set; }
    }
}
