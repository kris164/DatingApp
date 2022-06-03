using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class HubTeamLeaderAccept
    {
        public int HubTeamLeaderAcceptId { get; set; }
        public int HubGateRouteId { get; set; }
        public int? TeamLeaderId { get; set; }
        public string TeamLeader { get; set; }
        public DateTime AcceptDate { get; set; }
    }
}
