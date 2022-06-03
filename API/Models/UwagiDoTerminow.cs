using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class UwagiDoTerminow
    {
        public int IdUwagiDoTerminow { get; set; }
        public string Typ { get; set; }
        public int RecordId { get; set; }
        public DateTime Dt { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }
    }
}
