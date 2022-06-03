using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverTaskStatus
    {
        public SolverTaskStatus()
        {
            SolverTasks = new HashSet<SolverTask>();
        }

        public int SolverTaskStatusId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<SolverTask> SolverTasks { get; set; }
    }
}
