using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TerminateAppRequestSession
    {
        public int IdTerminateAppRequestSessions { get; set; }
        public int? TerminateAppRequestId { get; set; }
        public DateTime? RegisterDate { get; set; }
        public string AppName { get; set; }
        public int? UserId { get; set; }
        public int? IdSpeedLog { get; set; }

        public virtual TerminateAppRequest TerminateAppRequest { get; set; }
    }
}
