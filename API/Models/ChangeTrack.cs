using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ChangeTrack
    {
        public int ChangeTrackId { get; set; }
        public string Name { get; set; }
        public string Hint { get; set; }
        public string DatabaseObject { get; set; }
        public string FieldName { get; set; }
        public string TriggerName { get; set; }
        public int? DataType { get; set; }
        public int ObjectId { get; set; }
        public int Enabled { get; set; }
    }
}
