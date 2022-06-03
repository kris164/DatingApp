using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class UserLayout
    {
        public int UserLayoutId { get; set; }
        public int ToolId { get; set; }
        public int UserId { get; set; }
        public int LayoutTypeId { get; set; }
        public string Name { get; set; }
        public string Hint { get; set; }
        public byte[] Layout { get; set; }
        public int GridTypeId { get; set; }
        public byte[] ViewData { get; set; }
        public int ActiveView { get; set; }
        public int? MasterLayoutId { get; set; }
    }
}
