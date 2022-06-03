using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RequestConfigurationQueryBinding
    {
        public int RequestConfigurationQueryBindingId { get; set; }
        public int? RequestConfigurationQueryId { get; set; }
        public string FieldName { get; set; }
        public string Element { get; set; }
    }
}
