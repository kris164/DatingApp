using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class NavBar
    {
        public int NavBarId { get; set; }
        public string Name { get; set; }
        public int? Collapsed { get; set; }
        public string CustomName { get; set; }
        public string Hint { get; set; }
        public int? ParentId { get; set; }
        public int? MasterOrder { get; set; }
        public int? ChildOrder { get; set; }
        public int? LargeIconId { get; set; }
        public int? SmallIconId { get; set; }
        public int? DesktopIconId { get; set; }
        public int Location { get; set; }
        public int? ToolId { get; set; }
        public int? Active { get; set; }
        public int? Visible { get; set; }
    }
}
