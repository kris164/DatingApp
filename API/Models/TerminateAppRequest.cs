using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TerminateAppRequest
    {
        public TerminateAppRequest()
        {
            TerminateAppRequestSessions = new HashSet<TerminateAppRequestSession>();
        }

        public int IdTerminateAppRequest { get; set; }
        public string AppName { get; set; }
        public DateTime? ForceTerminateDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string TerminateInfo { get; set; }
        public DateTime? RegisterDate { get; set; }
        public int? RegisterUserId { get; set; }
        public string RegisterUserName { get; set; }
        public string RegisterAppVersion { get; set; }
        public int? Disabled { get; set; }

        public virtual ICollection<TerminateAppRequestSession> TerminateAppRequestSessions { get; set; }
    }
}
