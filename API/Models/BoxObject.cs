using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class BoxObject
    {
        public int BoxObjectId { get; set; }
        public string BoxClass { get; set; }
        public int? ObjectId { get; set; }
        public int? Analysis { get; set; }
        public int? History { get; set; }
    }
}
