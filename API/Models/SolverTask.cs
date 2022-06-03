using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverTask
    {
        public SolverTask()
        {
            SolverSolutions = new HashSet<SolverSolution>();
        }

        public int SolverTaskId { get; set; }
        public int StatusId { get; set; }
        public int SolverTaskTypeId { get; set; }
        public string SolverConfig { get; set; }
        public int? BestSolutionId { get; set; }
        public int? SessionId { get; set; }
        public string ErrorMsg { get; set; }
        public int? ObjId { get; set; }
        public int? Recid { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        public virtual SolverTaskType SolverTaskType { get; set; }
        public virtual SolverTaskStatus Status { get; set; }
        public virtual ICollection<SolverSolution> SolverSolutions { get; set; }
    }
}
