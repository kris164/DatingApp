using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class DpsHepTable
    {
        public int Id { get; set; }
        public DateTime? Dt { get; set; }
        public int? SessionId { get; set; }
        public int? Status { get; set; }
        public string Msg { get; set; }
    }
}
