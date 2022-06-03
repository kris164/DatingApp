using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MapDetail
    {
        public int MapDetailsId { get; set; }
        public int? ObjectId { get; set; }
        public int? RecId { get; set; }
        public DateTime? TimeStamp { get; set; }
    }
}
