using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ImportObject
    {
        public int ImportObjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? MasterObjectId { get; set; }
        public string ImportProcedure { get; set; }
        public int? Visible { get; set; }
        public int? System { get; set; }
        public int? AppSchemaId { get; set; }
    }
}
