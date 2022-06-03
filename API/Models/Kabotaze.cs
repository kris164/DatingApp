using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Kabotaze
    {
        public long? Id { get; set; }
        public int? SolverTaskId { get; set; }
        public int? SessionId { get; set; }
        public int? IdTaboru { get; set; }
        public string LokalizacjaKraj { get; set; }
        public int IdZlecenia { get; set; }
        public DateTime? PlanDataZal { get; set; }
        public string KrajZa { get; set; }
        public string KrajWy { get; set; }
        public int? Kabotaz { get; set; }
        public int? WjazdDonastępnegoKrajuNaPusto { get; set; }
        public int? KabotazNaPusto { get; set; }
        public int? IloscKabotazy { get; set; }
        public int? Pomin { get; set; }
    }
}
