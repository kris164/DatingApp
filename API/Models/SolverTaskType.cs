using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverTaskType
    {
        public SolverTaskType()
        {
            SolverTasks = new HashSet<SolverTask>();
        }

        public int SolverTaskTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<SolverTask> SolverTasks { get; set; }
    }
}
