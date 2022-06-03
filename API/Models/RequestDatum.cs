using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RequestDatum
    {
        public int RequestDataId { get; set; }
        public int? SessionId { get; set; }
        public string Element { get; set; }
        public string ElementName { get; set; }
        public string ElementValue { get; set; }
        public int? ElementIndex { get; set; }
        public string XmlData { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
