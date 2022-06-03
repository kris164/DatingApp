using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class DataRecordType
    {
        public int IdDataRecordType { get; set; }
        public string Name { get; set; }
        public string FieldName { get; set; }
        public string Description { get; set; }
    }
}
