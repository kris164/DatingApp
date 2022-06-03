using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ImportObjectDefinition
    {
        public int ImportObjectDefinitionId { get; set; }
        public int ImportObjectId { get; set; }
        public string Destination { get; set; }
        public string DestinationField { get; set; }
        public string Description { get; set; }
    }
}
