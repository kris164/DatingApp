using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SchemaAccess
    {
        public int SchemaAccessId { get; set; }
        public int AppSchemaId { get; set; }
        public int OlapGroupId { get; set; }
    }
}
