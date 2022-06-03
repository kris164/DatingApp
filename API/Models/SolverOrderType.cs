using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SolverOrderType
    {
        public SolverOrderType()
        {
            SolverOrders = new HashSet<SolverOrder>();
        }

        public int OrderTypeId { get; set; }
        public string OrderTypeName { get; set; }

        public virtual ICollection<SolverOrder> SolverOrders { get; set; }
    }
}
