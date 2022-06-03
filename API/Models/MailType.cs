using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MailType
    {
        public int MailTypeId { get; set; }
        public string Type { get; set; }
        public int? Incoming { get; set; }
        public int? Outgoing { get; set; }
    }
}
