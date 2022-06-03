using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RequestForm
    {
        public int RequestFormId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? RequestFormBaseTypeId { get; set; }
        public int? ClientId { get; set; }
    }
}
