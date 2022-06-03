using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaskType
    {
        public int TaskTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
