using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class StatusOfStopOutsideMin
    {
        public int StatusOfStopOutsideMinId { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? ObjectTypeId { get; set; }
        public int? ObjectId { get; set; }
        public int? PositionId { get; set; }
        public int? Alert { get; set; }
    }
}
