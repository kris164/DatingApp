using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class UserPasswordHistory
    {
        public int UserPasswordHistoryId { get; set; }
        public int? UserId { get; set; }
        public byte[] Password { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
