using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class RequestPermissionDependency
    {
        public int RequestPermissionDependencyId { get; set; }
        public int RequestPermissionId { get; set; }
        public int DependencyId { get; set; }
        public int? Active { get; set; }
    }
}
