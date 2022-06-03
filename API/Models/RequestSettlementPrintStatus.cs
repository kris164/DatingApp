using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RequestSettlementPrintStatus
    {
        public int Id { get; set; }
        public int? SettlementId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Status { get; set; }
        public DateTime? ExecuteDate { get; set; }
        public int? Type { get; set; }
        public int? InvoiceId { get; set; }
    }
}
