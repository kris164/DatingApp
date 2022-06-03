using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Locker
    {
        public int LockerId { get; set; }
        public string TableName { get; set; }
        public int RecordId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string ComputerName { get; set; }
        public string SessionParams { get; set; }
        public DateTime? LockDate { get; set; }
    }
}
