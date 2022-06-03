using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaskScheduler
    {
        public int TaskSchedulerId { get; set; }
        public int TaskId { get; set; }
        public int TaskRecurenceId { get; set; }
        public string Interval { get; set; }
        public int? Increment { get; set; }
        public int? Color { get; set; }
        public string Params { get; set; }
        public string Configuration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? StartDay { get; set; }
        public DateTime? NextRun { get; set; }
        public int? Enabled { get; set; }
    }
}
