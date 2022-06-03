using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class UserLayout1
    {
        public int IdUserLayout { get; set; }
        public int? UserId { get; set; }
        public string WinName { get; set; }
        public string ViewName { get; set; }
        public string Name { get; set; }
        public string IniName { get; set; }
        public int? DefaultView { get; set; }
        public string Data { get; set; }
    }
}
