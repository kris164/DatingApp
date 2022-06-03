using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverMessage
    {
        public int MessageId { get; set; }
        public int SolverTaskId { get; set; }
        public int? SolverSolutionId { get; set; }
        public int MessageTypeId { get; set; }
        public string Message { get; set; }

        public virtual SolverMessageType MessageType { get; set; }
        public virtual SolverSolution SolverSolution { get; set; }
        public virtual SolverTask SolverTask { get; set; }
    }
}
