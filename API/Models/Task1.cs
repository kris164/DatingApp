using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Task1
    {
        public int TaskId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TaskServiceTypeId { get; set; }
        public int TaskTypeId { get; set; }
        public string Command { get; set; }
        public int? Enabled { get; set; }
        public int CreateUserId { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? EditUserId { get; set; }
        public string EditUser { get; set; }
        public DateTime? EditDate { get; set; }
    }
}
