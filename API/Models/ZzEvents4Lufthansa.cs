using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ZzEvents4Lufthansa
    {
        public int IdZzEvents4Lufthansa { get; set; }
        public int ZlecenieId { get; set; }
        public DateTime? InsertDt { get; set; }
        public DateTime? DoneDt { get; set; }
        public int? Done { get; set; }
        public string DoneInfo { get; set; }
    }
}
