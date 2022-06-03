using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Userprofile
    {
        public int IdUserprofile { get; set; }
        public int IdUser { get; set; }
        public int IdProfile { get; set; }
        public string Program { get; set; }
        public byte[] Prawa { get; set; }
        public int? Blobver { get; set; }
    }
}
