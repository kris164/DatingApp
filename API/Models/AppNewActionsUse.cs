using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class AppNewActionsUse
    {
        public int IdAppNewActionsUse { get; set; }
        public int IdAppNewActions { get; set; }
        public int IdProfile { get; set; }
        public int? WindowType { get; set; }
        public string WindowMode { get; set; }
        public DateTime DtCreate { get; set; }

        public virtual AppNewAction IdAppNewActionsNavigation { get; set; }
        public virtual Profile1 IdProfileNavigation { get; set; }
    }
}
