using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaskSchedulerOutput
    {
        public int TaskSchedulerOutputId { get; set; }
        public int TaskSchedulerId { get; set; }
        public int OutputTypeId { get; set; }
        public int? EmailId { get; set; }
        public int? FileTransferProtocolId { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Directory { get; set; }
        public string Output { get; set; }
        public int? Enabled { get; set; }
    }
}
