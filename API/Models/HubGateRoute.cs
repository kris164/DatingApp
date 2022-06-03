using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class HubGateRoute
    {
        public int HubGateRouteId { get; set; }
        public int? HubGateId { get; set; }
        public int RouteWaypoinId { get; set; }
        public int? HubGateEventTypeId { get; set; }
        public DateTime EventStart { get; set; }
        public DateTime EventStop { get; set; }
        public string EventNote { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateDate { get; set; }
        public int? ModifyUserId { get; set; }
        public string ModifyUserName { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
