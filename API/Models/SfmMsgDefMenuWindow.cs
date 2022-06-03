using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmMsgDefMenuWindow
    {
        public int IdSfmMsgDefMenuWindow { get; set; }
        public int IdSfmMsgDefMenu { get; set; }
        public string ClassName { get; set; }

        public virtual SfmMsgdefmenu IdSfmMsgDefMenuNavigation { get; set; }
    }
}
