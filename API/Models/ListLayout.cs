using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ListLayout
    {
        public int ListLayoutId { get; set; }
        public int ToolId { get; set; }
        public int ListLayoutTypeId { get; set; }
        public string Name { get; set; }
        public string CustomName { get; set; }
        public string Hint { get; set; }
        public byte[] Layout { get; set; }
        public byte[] ViewData { get; set; }
        public int DefaultLayout { get; set; }
        public int Visible { get; set; }
        public int GridTypeId { get; set; }
    }
}
