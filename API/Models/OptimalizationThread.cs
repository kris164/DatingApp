using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class OptimalizationThread
    {
        public int OptimalizationThreadsId { get; set; }
        public int SessionId { get; set; }
        public int RunState { get; set; }
        public DateTime StartDt { get; set; }
        public int UserId { get; set; }
        public int? ErrorId { get; set; }
        public string ErrorMsg { get; set; }
    }
}
