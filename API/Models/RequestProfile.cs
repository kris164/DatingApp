using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RequestProfile
    {
        public int RequestProfileId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Enabled { get; set; }
        public int? Visible { get; set; }
        public string PasswordResetDatePart { get; set; }
        public int? PasswordResetOffset { get; set; }
        public DateTime? LastPasswordReset { get; set; }
        public int? ClientId { get; set; }
        public int? DefaultProfile { get; set; }
    }
}
