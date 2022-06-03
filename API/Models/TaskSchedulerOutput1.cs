using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaskSchedulerOutput1
    {
        public int TaskSchedulerOutputId { get; set; }
        public int TaskSchedulerId { get; set; }
        public string Directory { get; set; }
        public byte[] Layout { get; set; }
        public string Output { get; set; }
        public int? Enabled { get; set; }
        public int? EmailId { get; set; }
        public string Recipient { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public int? OutputTypeId { get; set; }
        public string Sender { get; set; }
    }
}
