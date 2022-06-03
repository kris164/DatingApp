using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Result101
    {
        public int Id { get; set; }
        public DateTime? Dt { get; set; }
        public int? SessionId { get; set; }
        public string GroupId { get; set; }
        public string MapProfileId { get; set; }
        public int? MapToll { get; set; }
        public string Tasks { get; set; }
    }
}
