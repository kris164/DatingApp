using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class StatusyZdarz
    {
        public int IdStatusyZdarz { get; set; }
        public int? Obiekt { get; set; }
        public string KodZdarz { get; set; }
        public string Status { get; set; }
        public string InfoZdarz { get; set; }
        public string StatusOrg { get; set; }
    }
}
