using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Task
    {
        public int TaskId { get; set; }
        public int ToolId { get; set; }
        public int? Enabled { get; set; }
        public int CreateUserId { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? EditUserId { get; set; }
        public string EditUser { get; set; }
        public DateTime? EditDate { get; set; }
    }
}
