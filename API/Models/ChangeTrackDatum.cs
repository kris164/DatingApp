using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ChangeTrackDatum
    {
        public int ChangeTrackDataId { get; set; }
        public int ChangeTrackId { get; set; }
        public int RecordId { get; set; }
        public string Host { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public object ValueBefore { get; set; }
        public object ValueAfter { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
