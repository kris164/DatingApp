using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class DashboardObject
    {
        public int DashboardObjectId { get; set; }
        public int? DashboardId { get; set; }
        public int? ObjectId { get; set; }
    }
}
