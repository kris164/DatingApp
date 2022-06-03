using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverCountry
    {
        public SolverCountry()
        {
            SolverPois = new HashSet<SolverPoi>();
        }

        public int SolverTaskId { get; set; }
        public string CountryCode2 { get; set; }
        public string CountryCode3 { get; set; }
        public string VehicleCode { get; set; }
        public string Name { get; set; }

        public virtual ICollection<SolverPoi> SolverPois { get; set; }
    }
}
