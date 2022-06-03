using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RequestInvoicePeriod
    {
        public int Id { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public int? FirstDay { get; set; }
        public int? LastDay { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
    }
}
