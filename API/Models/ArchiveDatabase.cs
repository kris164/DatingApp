using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ArchiveDatabase
    {
        public int IdArchiveDatabase { get; set; }
        public string Name { get; set; }
        public DateTime? ArchiveDt { get; set; }
        public string ConnectionString { get; set; }
    }
}
