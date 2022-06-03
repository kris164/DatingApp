using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Icon
    {
        public int IconId { get; set; }
        public string Name { get; set; }
        public int? ImageClass { get; set; }
        public byte[] Icon1 { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
    }
}
