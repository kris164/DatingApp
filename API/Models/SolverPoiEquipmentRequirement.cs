using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverPoiEquipmentRequirement
    {
        public int SolverTaskId { get; set; }
        public int SolverPoiId { get; set; }
        public string EquipmentName { get; set; }

        public virtual SolverPoi Solver { get; set; }
    }
}
