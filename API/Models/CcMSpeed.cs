using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class CcMSpeed
    {
        public int IdCcMSpeed { get; set; }
        public int? TaskObjId { get; set; }
        public int? TaskRecId { get; set; }
        public int? MasterRecId { get; set; }
        public int? Precision { get; set; }
        public string Polyline { get; set; }
    }
}
