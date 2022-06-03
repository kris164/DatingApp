using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RequestToken
    {
        public int RequestTokenId { get; set; }
        public int? UserId { get; set; }
        public string Token { get; set; }
        public string Salt { get; set; }
        public DateTime? Expire { get; set; }
        public string Hash { get; set; }
    }
}
