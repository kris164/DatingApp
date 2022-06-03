using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverOrderEquipmentRequirement
    {
        public int SolverTaskId { get; set; }
        public int SolverOrderId { get; set; }
        public string EquipmentName { get; set; }

        public virtual SolverOrder Solver { get; set; }
    }
}
