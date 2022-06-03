using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class LayoutTemplate
    {
        public int IdLayoutTemplate { get; set; }
        public string WinName { get; set; }
        public string ViewName { get; set; }
        public string Name { get; set; }
        public string IniName { get; set; }
        public string Data { get; set; }
    }
}
