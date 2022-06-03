using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ApplicationStatistic
    {
        public int ApplicationStatisticId { get; set; }
        public int? NavBarItemId { get; set; }
        public int? ToolId { get; set; }
        public int? UserId { get; set; }
        public int Counter { get; set; }
    }
}
