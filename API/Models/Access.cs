using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Access
    {
        public int AccessId { get; set; }
        public int? DefinitionId { get; set; }
        public int? UserId { get; set; }
        public int? UserGroupId { get; set; }
        public int? Edit { get; set; }
        public int? View { get; set; }
    }
}
