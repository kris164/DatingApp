using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Sfmcheck
    {
        public int SfmcheckId { get; set; }
        public string Name { get; set; }
        public DateTime? LastDate { get; set; }
        public int? Status { get; set; }
    }
}
