using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ImportFileType
    {
        public int ImportFileTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FieldDelimiter { get; set; }
        public string FileExtension { get; set; }
        public int? Visible { get; set; }
    }
}
