using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class MultilingualText
    {
        public int MultilingualTextId { get; set; }
        public int WindowId { get; set; }
        public int ControlId { get; set; }
        public int TextId { get; set; }
    }
}
