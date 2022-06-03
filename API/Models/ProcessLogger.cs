using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ProcessLogger
    {
        public int ProcessLoggerId { get; set; }
        public int? ToolId { get; set; }
        public string Params { get; set; }
        public string ContextInfo { get; set; }
        public string Information { get; set; }
        public int? Severity { get; set; }
        public int? ClientProcessId { get; set; }
        public string ClientHost { get; set; }
        public string ApplicationName { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
