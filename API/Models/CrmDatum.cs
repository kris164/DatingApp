using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class CrmDatum
    {
        public int CrmDataId { get; set; }
        public string Crm { get; set; }
        public int? NewMessage { get; set; }
        public int? Inbox { get; set; }
        public int? ExternalIndex { get; set; }
        public int? ContractorId { get; set; }
        public int? CrmTypeKey { get; set; }
        public string CrmTypeValue { get; set; }
        public int? CrmSubtypeKey { get; set; }
        public string CrmSubtypeValue { get; set; }
        public string Sender { get; set; }
        public string To { get; set; }
        public string Email { get; set; }
        public string ConversationIndex { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime? ReceivedTime { get; set; }
        public string XmlData { get; set; }
        public int? State { get; set; }
    }
}
