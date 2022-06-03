using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class OptiplanLog
    {
        public DateTime PlanDate { get; set; }
        public int ZlecenieId { get; set; }
        public int SamochodId { get; set; }
    }
}
