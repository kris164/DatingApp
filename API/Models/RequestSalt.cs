using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RequestSalt
    {
        public int RequestSaltId { get; set; }
        public string User { get; set; }
        public string Salt { get; set; }
        public DateTime? Expire { get; set; }
    }
}
