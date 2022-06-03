using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ChangeTrackDatabase
    {
        public int ChangeTrackDatabaseId { get; set; }
        public string Database { get; set; }
        public string Table { get; set; }
        public int ObjectId { get; set; }
        public int Enabled { get; set; }
    }
}
