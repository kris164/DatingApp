using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class HubGate
    {
        public int HubGateId { get; set; }
        public string Name { get; set; }
        public string Hint { get; set; }
        public int HubGateTypeId { get; set; }
        public int? IconId { get; set; }
        public int? Color { get; set; }
        public string Barcode { get; set; }
        public int LocalizationId { get; set; }
        public int? Order { get; set; }
        public int? DefaultOperationTime { get; set; }
        public int GateModeId { get; set; }
    }
}
