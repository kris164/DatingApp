using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Text
    {
        public int TextId { get; set; }
        public string Value { get; set; }
        public string Hash { get; set; }
    }
}
