using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class HubGateLayout
    {
        public int HubGateLayoutId { get; set; }
        public int UserId { get; set; }
        public int LocalizationId { get; set; }
        public byte[] Layout { get; set; }
    }
}
