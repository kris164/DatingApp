using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Dashboard
    {
        public int DashboardId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Dashboard1 { get; set; }
        public int? Refresh { get; set; }
        public int? Enabled { get; set; }
        public int? System { get; set; }
        public int CreateUserId { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? EditUserId { get; set; }
        public string EditUser { get; set; }
        public DateTime? EditDate { get; set; }
    }
}
