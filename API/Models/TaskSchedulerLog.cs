using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaskSchedulerLog
    {
        public int TaskSchedulerLogId { get; set; }
        public int? Ssl { get; set; }
        public int? SendStatus { get; set; }
        public int? Error { get; set; }
        public string MailMessage { get; set; }
        public string Sender { get; set; }
        public string Receipient { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Attachment { get; set; }
        public DateTime CreateDatetime { get; set; }
    }
}
