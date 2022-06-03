using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Mail
    {
        public int MailId { get; set; }
        public int MailTypeId { get; set; }
        public string ServerName { get; set; }
        public int? ServerPort { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public int? AuthMechanism { get; set; }
        public int? Ssl { get; set; }
        public int? SslstartMode { get; set; }
        public int? DefaultMail { get; set; }
        public string Name { get; set; }
        public int? CipherType { get; set; }
    }
}
